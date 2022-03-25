using InventoryManagement.Infrastructure.Persistence;
using SoccerFieldBooking.Domain.Enums;
using SoccerFieldBooking.Domain.Model;
using SoccerFieldBooking.Domain.ValueObjects;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerFieldBooking.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            if (!context.Companies.Any())
            {
                //Companies
                var companyLochin = CreateCompany("Lochin", 4.5m, 100, "33 mkr", "735733");
                var companySpartak = CreateCompany("Spartak", 4m, 100, "8 mkr", "735708");
                var companyParlament = CreateCompany("Parlament", 3.5m, 50, "31 mkr", "735731");
                context.Companies.AddRange(companyLochin, companySpartak, companyParlament);

                //ContactPersons
                var contactPersonLochin = CreateContactPerson("Daler", "1122", companyLochin);
                var contactPersonSpartak = CreateContactPerson("Mirzo", "4444", companySpartak);
                var contactPersonParlament = CreateContactPerson("Ataev", "9876", companyParlament);
                context.Contacts.AddRange(contactPersonLochin, contactPersonSpartak, contactPersonParlament);

                //Fields
                var lochinFieldA = CreateField("A", 12, companyLochin);
                var lochinFieldB = CreateField("B", 12, companyLochin);
                var lochinFieldC = CreateField("C", 14, companyLochin);

                var spartakFieldA = CreateField("A", 12, companySpartak);
                var spartakFieldB = CreateField("B", 12, companySpartak);

                var parlamentFieldA = CreateField("A", 10, companyParlament);
                context.Fields.AddRange(lochinFieldA, lochinFieldB, lochinFieldC, spartakFieldA, spartakFieldB, parlamentFieldA);

                //Customers
                var customer1 = CreateCustomer("Rustam", "1111", "rustam@test.te");
                var customer2 = CreateCustomer("Parviz", "2222");
                var customer3 = CreateCustomer("Naim", "3333", "naim@test.te");
                var customer4 = CreateCustomer("Mihail", "4444", "mihail@test.te");
                var customer5 = CreateCustomer("Alex", "5555", "alex@test.te");
                context.Customers.AddRange(customer1, customer2, customer3, customer4, customer5);

                await context.SaveChangesAsync();
            }
        }

        static Company CreateCompany(string name, decimal rate, int price, string street, string postalCode)
        {
            return new Company
            {
                Name = name,
                Rating = rate,
                Address = new Address("Tajikistan", "Sogd", "Khujand", street, postalCode),
                AccountState = AccountState.Active,
                PricePerHour = price,
                CreatedDate = DateTime.Today
            };
        }

        static ContactPerson CreateContactPerson(string name, string phone, Company company)
        {
            return new ContactPerson
            {
                Name = name,
                Phone = $"+99292777{phone}",
                Company = company
            };
        }

        static Field CreateField(string name, int capacity, Company company)
        {
            return new Field
            {
                Name = name,
                Size = new FieldSize(25, 60),
                Capacity = capacity,
                Company = company
            };
        }

        static Customer CreateCustomer(string name, string phone, string email = "")
        {
            return new Customer
            {
                Name = name,
                Phone = $"+99292754{phone}",
                Email = email
            };
        }

    }
}
