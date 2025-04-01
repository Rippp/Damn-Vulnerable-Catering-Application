using DamnVulnerableCateringApplication.DataObjects;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using System.Configuration;
using System.IO;
using iText.Commons.Actions;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics;

namespace DamnVulnerableCateringApplication
{
    public static class HTTPHandler
    {
        private static string defaultLogin = "klient@klient.pl";
        private static string defaultPass = "Klient123!";
        private static Uri CateringBackendAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);
        private static bool _isAuthenticated = false;

        private static HttpClientHandler _handler = new HttpClientHandler()
        {
            ServerCertificateCustomValidationCallback = PinPublicKey
        };

        private static bool PinPublicKey(object sender, X509Certificate2? cert, X509Chain? chain, SslPolicyErrors policyErrors)
        {
            var certThumbprint = cert.GetCertHashString();
            return string.Equals(certThumbprint, "8CFCE09EA0ECCDE1C61398254221760972055F51", StringComparison.OrdinalIgnoreCase);
        }

        private static HttpClient client = new HttpClient(_handler)
        {
            BaseAddress = CateringBackendAddress
        };

        public static Client GetAccountDetails()
        {
            ClientDTO returnedDetails = new ClientDTO();

            if (_isAuthenticated)
            {
                var result = client.GetAsync(new Uri(client.BaseAddress, "Client/account")).Result;
                LogResult(result);
                if (result.IsSuccessStatusCode)
                    returnedDetails = JsonConvert.DeserializeObject<ClientDTO>(result.Content.ReadAsStringAsync().Result);
            }

            return new Client(returnedDetails);
        }

        public static bool PutAccountDetails(Client newClient)
        {
            if (_isAuthenticated)
            {
                var payload = JsonConvert.SerializeObject(new ClientDTO(newClient));
                var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

                var result = client.PutAsync(new Uri(client.BaseAddress, "Client/account"), httpContent).Result;
                LogResult(result);
                if (result.IsSuccessStatusCode)
                { 
                    return true; 
                }
                else
                {
                    ShowErrorMessageBox();
                }
            }
            else
            {
                ShowErrorMessageBox("You can't perform this action while being unauthenticated");
            }

            return false;
        }

        public static List<Diet> GetAllDiets()
        {
            if (_isAuthenticated)
            {
                var result = client.GetAsync(new Uri(client.BaseAddress, "Diets")).Result;
                LogResult(result);
                if (result.IsSuccessStatusCode)
                {
                    var dietsDTO = JsonConvert.DeserializeObject<List<DietDTO>>(result.Content.ReadAsStringAsync().Result);
                    return dietsDTO.ConvertAll(x => new Diet(x));
                }
                else
                {
                    ShowErrorMessageBox();
                }
            }
            else
            {
                ShowErrorMessageBox("You can't perform this action while being unauthenticated");
            }

            return new List<Diet>();
        }

        public static DietDetails GetDietDetails(string dietID)
        {
            if (_isAuthenticated)
            {
                var result = client.GetAsync(new Uri(client.BaseAddress, "Diets/" + dietID)).Result;
                LogResult(result);
                if (result.IsSuccessStatusCode)
                {
                    var dietDetailsDTO = JsonConvert.DeserializeObject<DietDetailsDTO>(result.Content.ReadAsStringAsync().Result);
                    return new DietDetails(dietDetailsDTO);
                }
                else
                {
                    ShowErrorMessageBox();
                }
            }
            else
            {
                ShowErrorMessageBox("You can't perform this action while being unauthenticated");
            }
            return new DietDetails();
        }

        public static MealDetails GetMealDetails(string mealID)
        {
            if (_isAuthenticated)
            {
                var result = client.GetAsync(new Uri(client.BaseAddress, "Meals/" + mealID)).Result;
                LogResult(result);
                if (result.IsSuccessStatusCode)
                {
                    var mealDetailsDTO = JsonConvert.DeserializeObject<MealDetailsDTO>(result.Content.ReadAsStringAsync().Result);
                    return new MealDetails(mealDetailsDTO);
                }
                else
                {
                    ShowErrorMessageBox();
                }
            }
            else
            {
                ShowErrorMessageBox("You can't perform this action while being unauthenticated");
            }
            return new MealDetails();
        }

        public static bool PostClientOrders(Order order)
        {
            if (_isAuthenticated)
            {
                var payload = JsonConvert.SerializeObject(new OrderDTO(order));
                var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

                var result = client.PostAsync(new Uri(client.BaseAddress, "Client/orders"), httpContent).Result;
                LogResult(result);
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    ShowErrorMessageBox();
                }
            }
            else
            {
                ShowErrorMessageBox("You can't perform this action while being unauthenticated");
            }
            return false;
        }

        public static List<OrderDetailsDTO> GetClientOrders()
        {
            if (_isAuthenticated)
            {
                var result = client.GetAsync(new Uri(client.BaseAddress, "Client/orders")).Result;
                LogResult(result);
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<OrderDetailsDTO>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    ShowErrorMessageBox();
                }
            }
            else
            {
                ShowErrorMessageBox("You can't perform this action while being unauthenticated");
            }

            return new List<OrderDetailsDTO>();
        }

        public static bool Authenticate(string email, string password)
        {
            var parameters = new Dictionary<string, string>
            {
                {"email", email},
                {"password", password}
            };

            var result = client.PostAsJsonAsync(new Uri(client.BaseAddress, "Client/login"), parameters).Result;
            LogResult(result);
            if (result.IsSuccessStatusCode) SetJWTFromBody(result);

            return result.IsSuccessStatusCode;
        }

        public static bool Register(Client clientData)
        {
            var payload = JsonConvert.SerializeObject(new ClientDTO(clientData));
            var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

            var result = client.PostAsync(new Uri(client.BaseAddress, "Client/register"), httpContent).Result;
            LogResult(result);
            if (result.IsSuccessStatusCode) SetJWTFromBody(result);

            return result.IsSuccessStatusCode;
        }

        private static void SetJWTFromBody(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                _isAuthenticated = true;
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", response.Content.ReadAsStringAsync().Result);
            }
        }

        private static void ShowErrorMessageBox(string message = "Something went wrong")
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void LogResult(HttpResponseMessage result)
        {
            var TempPath = Path.GetTempPath();
            var filename = Guid.NewGuid().ToString();
            var filePath = Path.Combine(TempPath, filename);

            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"[{DateTime.Now}]");
                writer.WriteLine($"Status Code: {result.StatusCode}");
                writer.WriteLine($"Reason Phrase: {result.ReasonPhrase}");

                foreach (var header in result.Headers)
                {
                    writer.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
                }
                if (result.Content.Headers != null)
                {
                    foreach (var header in result.Content.Headers)
                    {
                        writer.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
                    }
                }
                if (result.Content != null)
                {
                    string content = result.Content.ReadAsStringAsync().Result;
                    writer.WriteLine(content);
                }
            }
        }

        public static void UpdateHandler(bool enabled)
        {
            ConfigurationManager.RefreshSection("appSettings");
            CateringBackendAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);
            var oldToken = client.DefaultRequestHeaders.Authorization;
            if (enabled)
            {
                _handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = PinPublicKey
                };
            }
            else
            {
                _handler = new HttpClientHandler();
            }

            client = new HttpClient(_handler)
            {
                BaseAddress = CateringBackendAddress
            };
            client.DefaultRequestHeaders.Authorization = oldToken;
        }
    }

}
