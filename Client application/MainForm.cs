using DamnVulnerableCateringApplication;
using DamnVulnerableCateringApplication.DataObjects;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using ScottPlot;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace ReaLTaiizor.UI
{
    public partial class MainForm : MaterialForm
    {
        public Client currentClient;

        private MaterialSkinManager _skinManager;
        private DietDetailsForm _currentDietDetailsForm;
        private readonly LoginForm _loginForm;
        private bool _isOffline;
        private List<Diet> _currentDietList = new List<Diet>();
        private List<Diet> _basket = new List<Diet>();
        private List<OrderDetailsDTO> _currentClientOrders = new List<OrderDetailsDTO>();
        private List<WeightDiagramItem> _diagramItems = new List<WeightDiagramItem>();

        private readonly MaterialSkinManager materialSkinManager;
        private List<(string name, MaterialColorScheme colorScheme)> _colorSchemes = new List<(string name, MaterialColorScheme colorScheme)>()
        {
            (name: "Mandarin", colorScheme: new MaterialColorScheme(System.Drawing.Color.Orange, System.Drawing.Color.DarkOrange, System.Drawing.Color.Orchid, System.Drawing.Color.OrangeRed, System.Drawing.Color.MediumOrchid)),
            (name: "Magenta", colorScheme: new MaterialColorScheme(0x00C926b3, 0xA1008B, 0xDC2EFF, 0x006E70FF, MaterialTextShade.LIGHT)),
            (name: "Violet", colorScheme: new MaterialColorScheme("#00480157", "#370142", "DC2EFF", "00BB5FCF", MaterialTextShade.LIGHT)),
            (name: "Indigo", colorScheme: new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT))
        };

        public MainForm(LoginForm loginForm, Client currentClient = null, bool isOffline = false)
        {
            this._loginForm = loginForm;
            this.currentClient = currentClient;
            this._isOffline = isOffline;

            if (currentClient == null && !isOffline)
                this.currentClient = HTTPHandler.GetAccountDetails();

            InitializeComponent();

            // Initialize MaterialSkinManager
            _skinManager = MaterialSkinManager.Instance;

            _skinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            _skinManager.AddFormToManage(this);
            _skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _skinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);

            if (!isOffline && _currentDietList.Count == 0)
                RefreshDietsButton_Click(null, null);

            if (!isOffline && _currentClientOrders.Count == 0)
                RefreshOrdersButton_Click(null, null);

            OrderFromDate.Value = DateTime.Now.AddDays(1);
            OrderToDate.Value = DateTime.Now.AddDays(1);

            foreach (var cs in _colorSchemes)
                colorSchemeListView.Items.Add(cs.name);

            DeserializeDiagramPoints();
            RefreshWeightPlot();
            foreach(var item in _diagramItems)
            {
                DiagramItemsListView.Items.Add(new ListViewItem(new[] { item.Day.ToShortDateString(), item.Weight.ToString() }));
            }

            LogoutButton.Text = isOffline ? "Login" : "Logout";
        }

        private void RefreshWeightPlot()
        {
            WeightPlot.Plot.Clear();

            DateTime[] Xs = _diagramItems.Select(x => x.Day.Date).ToArray();
            int[] Ys = _diagramItems.Select(x => x.Weight).ToArray();

            var myScatter = WeightPlot.Plot.Add.Scatter(Xs, Ys);

            myScatter.Color = ScottPlot.Colors.Blue;
            myScatter.LineWidth = 3;
            myScatter.MarkerSize = 10;
            myScatter.MarkerShape = MarkerShape.FilledDiamond;
            myScatter.LinePattern = LinePattern.DenselyDashed;

            WeightPlot.Plot.Axes.DateTimeTicksBottom();
            WeightPlot.Refresh();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.CloseAllForms();
        }

        private void CurrentPassTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangePasswordButtonUpdate();
        }

        private void NewPassTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangePasswordButtonUpdate();
        }

        private void NewPassAgainTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangePasswordButtonUpdate();
        }

        private void ChangePasswordButtonUpdate()
        {
            if (CurrentPassTextBox.Text == currentClient.Password &&
                NewPassAgainTextBox.Text == NewPassTextBox.Text &&
                NewPassAgainTextBox.Text.Length > 0)
            {
                ChangePassButton.Enabled = true;
                ChangePassButton.Type = MaterialButton.MaterialButtonType.Contained;
            }
            else
            {
                ChangePassButton.Enabled = false;
                ChangePassButton.Type = MaterialButton.MaterialButtonType.Outlined;
            }
        }

        private void ProfilePage_Enter(object sender, EventArgs e)
        {
            EmailTextBox.Text = currentClient?.Email;
            NameTextBox.Text = currentClient?.Name;
            SurnameTextBox.Text = currentClient?.Surname;
            PhoneTextBox.Text = currentClient?.Telephone;
            StreetTextBox.Text = currentClient?.Address.Street;
            StreetNoTextBox.Text = currentClient?.Address.StreetNo;
            PostalCodeTextBox.Text = currentClient?.Address.Postal;
            CityTextBox.Text = currentClient?.Address.City;
        }

        private void materialSwitch10_CheckedChanged(object sender, EventArgs e)
        {
            CurrentPassTextBox.PasswordChar = '\0';
            NewPassTextBox.PasswordChar = '\0';
            NewPassAgainTextBox.PasswordChar = '\0';

            CurrentPassTextBox.UseSystemPasswordChar = !materialSwitch10.Checked;
            NewPassTextBox.UseSystemPasswordChar = !materialSwitch10.Checked;
            NewPassAgainTextBox.UseSystemPasswordChar = !materialSwitch10.Checked;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (_isOffline)
                return;

            var newCurrentClient = new Client
            {
                Email = EmailTextBox.Text,
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Telephone = PhoneTextBox.Text,
                Password = currentClient.Password,
                Address = new Address
                {
                    Street = StreetTextBox.Text,
                    StreetNo = StreetNoTextBox.Text,
                    Postal = PostalCodeTextBox.Text,
                    City = CityTextBox.Text
                }
            };

            if (HTTPHandler.PutAccountDetails(newCurrentClient))
                currentClient = newCurrentClient;
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            var newCurrentClient = new Client
            {
                Email = currentClient.Email,
                Name = currentClient.Name,
                Surname = currentClient.Surname,
                Telephone = currentClient.Telephone,
                Password = NewPassAgainTextBox.Text,
                Address = new Address
                {
                    Street = currentClient.Address.Street,
                    StreetNo = currentClient.Address.StreetNo,
                    Postal = currentClient.Address.Postal,
                    City = currentClient.Address.City,
                }
            };

            if (HTTPHandler.PutAccountDetails(newCurrentClient))
                currentClient = newCurrentClient;
        }

        private void RefreshDietsButton_Click(object sender, EventArgs e)
        {
            var result = HTTPHandler.GetAllDiets();

            if (result.Count > 0)
            {
                _currentDietList = new List<Diet>(result);
                DietListView.Items.Clear();
            }
            foreach (var d in result)
                DietListView.Items.Add(d.ConvertToListViewItem());

            return;
        }

        private void DietListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = DietListView.Columns[e.ColumnIndex].Width;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (DietListView.SelectedItems.Count > 0)
            {
                var selectedID = DietListView.SelectedItems[0].SubItems[DietListView.SelectedItems[0].SubItems.Count - 1].Text;
                var diet = _currentDietList.Find(x => x.Id.ToString() == selectedID);
                _basket.Add(diet);
                BasketListView.Items.Add(diet.ConvertToListViewItem());
                UpdateTotalOrderCost();
            }
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (_isOffline)
                return;

            var newOrder = new Order()
            {
                Diets = new List<Diet>(_basket),
                DeliveryDetails = new DeliveryDetailsDTO(currentClient, DeliveryCommentTextBox.Text),
                StartDate = OrderFromDate.Value,
                EndDate = OrderToDate.Value
            };

            HTTPHandler.PostClientOrders(newOrder);
            return;
        }

        private void materialButton3_Click_1(object sender, EventArgs e)
        {
            if (BasketListView.SelectedItems.Count > 0)
            {
                var selectedID = BasketListView.SelectedItems[0].SubItems[BasketListView.SelectedItems[0].SubItems.Count - 1].Text;
                _basket.RemoveAll(x => x.Id.ToString() == selectedID);
                BasketListView.Items.Remove(BasketListView.SelectedItems[0]);
                UpdateTotalOrderCost();
            }
        }

        private void UpdateTotalOrderCost()
        {
            Decimal totalCost = 0;
            var dateRange = (int)Math.Ceiling((OrderToDate.Value - OrderFromDate.Value).TotalDays) + 1;
            _basket.ForEach(x => totalCost += x.Price * dateRange);
            TotalOrderCostLabel.Text = totalCost.ToString() + " PLN";
        }

        private void OrderFromDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void OrderToDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalOrderCost();
        }

        private void DietListView_DoubleClick(object sender, EventArgs e)
        {
            _currentDietDetailsForm?.Close();
            var selectedID = DietListView.SelectedItems[0].SubItems[DietListView.SelectedItems[0].SubItems.Count - 1].Text;
            var diet = _currentDietList.Find(x => x.Id.ToString() == selectedID);
            _currentDietDetailsForm = new DietDetailsForm(diet);
            _currentDietDetailsForm.ShowDialog();
        }

        private void RefreshOrdersButton_Click(object sender, EventArgs e)
        {
            var clientOrders = HTTPHandler.GetClientOrders();
            _currentClientOrders = new List<OrderDetailsDTO>(clientOrders);

            OrderListView.Items.Clear();
            foreach (var clientOrder in clientOrders)
            {
                OrderListView.Items.Add(new ListViewItem(new[] {
                    clientOrder.id, clientOrder.startDate.ToString("yyyy-MM-dd"), clientOrder.endDate.ToString("yyyy-MM-dd"), clientOrder.price.ToString()}));
            }
        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderListView.SelectedItems.Count > 0)
            {
                var selectedOrderId = OrderListView.SelectedItems[0].SubItems[0].Text;
                var order = _currentClientOrders.FirstOrDefault(x => x.id == selectedOrderId);

                DietInOrderListView.Items.Clear();
                foreach (var diet in order.diets)
                {
                    DietInOrderListView.Items.Add(new ListViewItem(diet.name));
                }

                OrderDetailCityTextBox.Text = order.deliveryDetails.address.city;
                OrderDetailPostalTextBox.Text = order.deliveryDetails.address.postCode;
                OderDetailStreetNoTextBox.Text = order.deliveryDetails.address.buildingNumber;
                OrderDetailStreetTextBox.Text = order.deliveryDetails.address.street;
                OrderDetailTelephoneTextBox.Text = order.deliveryDetails.phoneNumber;
                OrderDetailCommentTextBox.Text = order.deliveryDetails.commentForDeliverer;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginForm.Show();
        }

        private void CalculateBMRButton_Click(object sender, EventArgs e)
        {
            if (HeightTextBox.Text.Length == 0 ||
                WeightTextBox.Text.Length == 0 ||
                AgeTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter the data required to calculate the BMR index", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double calories = 0.0;
            if (MaleRadioButton.Checked)
            {
                calories = 66.0 + (13.7 * double.Parse(WeightTextBox.Text)) + (5.0 * double.Parse(HeightTextBox.Text)) - (6.8 * double.Parse(AgeTextBox.Text));
            }
            else if (FemaleRadioButton.Checked)
            {
                calories = 655.0 + (9.6 * double.Parse(WeightTextBox.Text)) + (1.8 * double.Parse(HeightTextBox.Text)) - (4.7 * double.Parse(AgeTextBox.Text));
            }

            BMRResultLabel.Text = ((int)calories).ToString() + " kcal";
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateOnlyNumbers(HeightTextBox.Text))
                HeightTextBox.Text = "";
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateOnlyNumbers(AgeTextBox.Text))
                AgeTextBox.Text = "";

        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateOnlyNumbers(WeightTextBox.Text))
                WeightTextBox.Text = "";

        }
        private bool ValidateOnlyNumbers(string text)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            var matches = regex.Matches(text);
            return matches.Count > 0;
        }

        private void BMIHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateOnlyNumbers(BMIHeightTextBox.Text))
                BMIHeightTextBox.Text = "";
        }

        private void BMIWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateOnlyNumbers(BMIWeightTextBox.Text))
                BMIWeightTextBox.Text = "";
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (BMIHeightTextBox.Text.Length == 0 ||
                BMIWeightTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter the data required to calculate BMI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double heightInM = double.Parse(BMIHeightTextBox.Text) / 100.0;
            double BMI = double.Parse(BMIWeightTextBox.Text) / (heightInM * heightInM);
            BMIResultLabel.Text = BMI.ToString("00.00");
        }

        private void AddDiagramButton_Click(object sender, EventArgs e)
        {
            if (AddDiagramWeigth.Text.Length == 0)
            {
                MessageBox.Show("Enter weight in kilograms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = new WeightDiagramItem()
            {
                Day = AddDiagramDate.Value.Date,
                Weight = int.Parse(AddDiagramWeigth.Text)
            };

            _diagramItems.Add(item);
            DiagramItemsListView.Items.Add(new ListViewItem(new[] { item.Day.ToShortDateString(), item.Weight.ToString() }));
            RefreshWeightPlot();

            SerializeDiagramPoints();
        }

        private void AddDiagramWeigth_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateOnlyNumbers(AddDiagramWeigth.Text))
                AddDiagramWeigth.Text = "";
        }

        private void RemoveFromWeightDiagramButton_Click(object sender, EventArgs e)
        {
            if (DiagramItemsListView.SelectedItems.Count == 0)
                return;

            var selectedItem = DiagramItemsListView.SelectedItems[0];

            _diagramItems.RemoveAll(x => x.Day.ToShortDateString() == selectedItem.SubItems[0].Text && x.Weight.ToString() == selectedItem.SubItems[1].Text);
            DiagramItemsListView.Items.Remove(selectedItem);

            RefreshWeightPlot();
            SerializeDiagramPoints();
        }

        private void ExportOrderToPDFButton_Click(object sender, EventArgs e)
        {
            if (OrderListView.SelectedItems.Count == 0)
                return;

            var dialogResult = MessageBox.Show(
                "Do you want to create an encrypted copy of the file?",
                "File encryption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool encrypted = dialogResult == DialogResult.Yes;
            string encryptionPassword = string.Empty;

            if (encrypted)
            {
                using(EncryptionForm encryptionForm = new EncryptionForm())
                {
                    if (encryptionForm.ShowDialog() == DialogResult.OK)
                    {
                        encryptionPassword = encryptionForm.EncryptionPassword;
                    }
                    else
                        encrypted = false;
                }
            }

            var selectedItemId = OrderListView.SelectedItems[0].SubItems[0].Text;
            var order = _currentClientOrders.FirstOrDefault(x => x.id == selectedItemId);

            string filepath = "order.pdf";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Select where to save the file";
                saveFileDialog.Filter = "PDF Files (*.pdf)|";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.FileName = "Order_" + order.id;


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    filepath = saveFileDialog.FileName;
            }

            using (PdfWriter writer = new PdfWriter(filepath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Invoice for order: " + order.id)
                        .SetFontSize(24)
                        .SimulateBold()
                        .SetMarginBottom(20));

                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 5, 2 })).UseAllAvailableWidth();

                    table.AddHeaderCell("Diet name");
                    table.AddHeaderCell("Price");

                    int totalPrice = 0;
                    foreach (var diet in order.diets)
                    {
                        table.AddCell(diet.name);
                        table.AddCell(diet.price + " PLN");
                        totalPrice += diet.price;
                    }
                    table.AddCell(new Cell().Add(new Paragraph("In total").SimulateBold()));
                    table.AddCell(new Cell().Add(new Paragraph(totalPrice.ToString() + " PLN").SimulateBold()));
                    document.Add(table);

                    var deliveryDetails = order.deliveryDetails;

                    document.Add(new Paragraph("Diet delivery period: " + order.startDate.ToShortDateString() + " - "
                        + order.endDate.ToShortDateString()));

                    document.Add(new Paragraph("Delivery details")
                        .SetFontSize(18)
                        .SimulateBold()
                        .SetMarginBottom(15));

                    document.Add(new Paragraph("Street: " + deliveryDetails.address.street + " " + deliveryDetails.address.buildingNumber));
                    document.Add(new Paragraph(deliveryDetails.address.postCode + " " + deliveryDetails.address.city));
                    document.Add(new Paragraph("Recipient's phone number: " + deliveryDetails.phoneNumber));

                    document.Close();
                }
            }

            if (!encrypted) return;

            using (FileStream inputStream = new FileStream(filepath, FileMode.Open))
            {
                using (FileStream outputStream = new FileStream(filepath.Replace(".pdf", ".enc"), FileMode.Create))
                {
                    using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                    {
                        des.Key = Encoding.UTF8.GetBytes(encryptionPassword);

                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, des.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            inputStream.CopyTo(cryptoStream);
                        }
                    }    
                }
            }

        }

        private void ChangeColorSchemeButton_Click(object sender, EventArgs e)
        {
            if (colorSchemeListView.SelectedItems.Count == 0) return;

            var selected = colorSchemeListView.SelectedItems[0].SubItems[0].Text;
            _skinManager.ColorScheme = _colorSchemes.FirstOrDefault(x => x.name == selected).colorScheme;

            this.Refresh();
        }

        private void CertificatePinningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HTTPHandler.UpdateHandler(CertificatePinningCheckBox.Checked);
        }

        private void SerializeDiagramPoints()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<WeightDiagramItem>));
            using (StreamWriter writer = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "weights")))
            {
                serializer.Serialize(writer, _diagramItems);
            }
        }

        private void DeserializeDiagramPoints()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "weights");
            if (!File.Exists(filePath))
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<WeightDiagramItem>));

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                _diagramItems = new List<WeightDiagramItem>((List<WeightDiagramItem>)serializer.Deserialize(stream));
            }
        }
    }
}