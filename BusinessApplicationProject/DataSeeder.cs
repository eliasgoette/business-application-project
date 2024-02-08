﻿using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;

namespace BusinessApplicationProject
{
    public static class DataSeeder
    {
        public static async Task InsertSeedData(AppDbContext context)
        {
            var addr1 = new Address
            {
                Country = "United States",
                City = "New York City",
                ZipCode = "NY 10016",
                StreetAddress = "277 5th Ave"
            };

            var addr2 = new Address
            {
                Country = "United States",
                City = "Santa Monica",
                ZipCode = "CA 90403",
                StreetAddress = "2525 Wilshire Blvd"
            };

            var cust1 = new Customer()
            {
                CustomerNumber = "CU-00001",
                CustomerAddress = addr1,
                FirstName = "John",
                LastName = "Smith",
                Email = "js@gmail.com"
            };

            var cust2 = new Customer()
            {
                CustomerNumber = "CU-00002",
                CustomerAddress = addr2,
                FirstName = "John",
                LastName = "Wayne",
                Email = "jw@gmail.com"
            };

            var artGrp1 = new ArticleGroup { Name = "Consumer Electronics" };
            var artGrp2 = new ArticleGroup { Parent = artGrp1, Name = "Personal Computing" };
            var artGrp3 = new ArticleGroup { Name = "Software" };
            var artGrp4 = new ArticleGroup { Parent = artGrp3, Name = "Subscription Based" };
            var artGrp5 = new ArticleGroup { Parent = artGrp4, Name = "Productivity" };

            var art1 = new Article()
            {
                ArticleNumber = "A-00001",
                Name = "MacBook Air 13",
                Price = 2100,
                Group = artGrp2
            };

            var art2 = new Article()
            {
                ArticleNumber = "A-00002",
                Name = "Chat GPT Pro 1 Mo",
                Price = 20,
                Group = artGrp5
            };

            var posList1 = new List<Position>() {
                new Position {
                    PositionNumber = 0,
                    ArticleDetails = art1,
                    Quantity = 1,
                    PurchasePrice = art1.Price
                },
                new Position
                {
                    PositionNumber = 1,
                    ArticleDetails = art2,
                    Quantity = 1,
                    PurchasePrice = art2.Price
                }
            };

            var posList2 = new List<Position>() {
                new Position
                {
                    PositionNumber = 0,
                    ArticleDetails = art2,
                    Quantity = 12,
                    PurchasePrice = 12 * art2.Price
                }
            };

            var ord1 = new Order
            {
                OrderNumber = "O-00001",
                Date = DateTime.Now,
                CustomerDetails = cust1,
                Positions = posList1
            };

            var ord2 = new Order
            {
                OrderNumber = "O-00002",
                Date = DateTime.Now.AddDays(5),
                CustomerDetails = cust2,
                Positions = posList2
            };

            var inv1 = new Invoice
            {
                InvoiceNumber = "I-00001",
                BillingAddress = ord1.CustomerDetails.CustomerAddress,
                DueDate = ord1.Date.AddDays(30),
                PaymentMethod = "Credit Card",
                PaymentStatus = "Paid",
                OrderInformations = ord1
            };

            var inv2 = new Invoice
            {
                InvoiceNumber = "I-00002",
                BillingAddress = ord2.CustomerDetails.CustomerAddress,
                DueDate = ord2.Date.AddDays(30),
                PaymentMethod = "Credit Card",
                PaymentStatus = "Pending",
                OrderInformations = ord2
            };


            var invRepo = new Repository<Invoice>(context);

            await invRepo.AddAsync(inv1);
            await invRepo.AddAsync(inv2);

            await context.SaveChangesAsync();
        }
    }
}