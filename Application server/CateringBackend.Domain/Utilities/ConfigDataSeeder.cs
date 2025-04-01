using CateringBackend.Domain.Data;
using CateringBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CateringBackend.Domain.Utilities
{
    public class ConfigDataSeeder
    {
        private readonly CateringDbContext _context;
        private readonly MealsAndDietsSeedDataProvider _mealsAndDietsSeedDataProvider;

        public ConfigDataSeeder(CateringDbContext context)
        {
            _context = context;
            _mealsAndDietsSeedDataProvider = new MealsAndDietsSeedDataProvider();
        }

        public void SeedConfigData()
        {
            SeedData(_context.Addresses, GetAddresses());
            SeedData(_context.Meals, GetMeals());
            _context.SaveChanges();

            SeedData(_context.Clients, GetClients(_context.Addresses));
            SeedData(_context.Diets, GetDiets());
            _context.SaveChanges();
        }

        private void SeedData<T>(DbSet<T> set, IEnumerable<T> data)
            where T : class
        {
            if (!set.Any())
                set.AddRange(data);
        }

        private IEnumerable<Diet> GetDiets() => _mealsAndDietsSeedDataProvider.DietsToSeed;

        private IEnumerable<Meal> GetMeals() => _mealsAndDietsSeedDataProvider.MealsToSeed;


        private IEnumerable<Client> GetClients(IEnumerable<Address> addresses)
        {
            yield return Client.Create("client@gmail.com", PasswordManager.Encrypt("client123"), "Mr.", "Client", "123456789", addresses.First().Id);
            yield return Client.Create("klient@klient.pl", PasswordManager.Encrypt("Klient123!"), "Mr.", "Klient", "123456789", addresses.First().Id);
        }

        private IEnumerable<Address> GetAddresses()
        {
            yield return Address.Create("Koszykowa", "98", "2a", "01-556", "Warszawa");
            yield return Address.Create("Hoża", "5", "1", "01-666", "Szczecin");
        }
    }
}
