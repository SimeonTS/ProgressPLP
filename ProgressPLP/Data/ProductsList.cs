﻿

namespace ProgressPLP.Data
{
    public class ProductsList
    {
        public static List<Product> ExampleProducts { get; set; } = new List<Product>()
        {

            new Product() { ProductId = 1, ProductName = "Chai", UnitInStock = 18, UnitPrice = 10.5m, DeliveryOn = new DateTime(2020, 12, 11) , ImageFileName = "product1.jpg"},
            new Product() { ProductId = 2, ProductName = "Chang", UnitInStock = 0, UnitPrice = 13m, DeliveryOn = new DateTime(2020, 12, 11), ImageFileName = "product2.png" },
            new Product() { ProductId = 3, ProductName = "Aniseed Syrup", UnitInStock = 1, UnitPrice = 6m, DeliveryOn = new DateTime(2020, 12, 11), ImageFileName = "product3.jpg" },
            new Product() { ProductId = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitInStock = 10, UnitPrice = 11.2m, DeliveryOn = new DateTime(2020, 11, 13), ImageFileName = "product4.jpg" },
            new Product() { ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", UnitInStock = 0, UnitPrice = 33m, DeliveryOn = new DateTime(2020, 11, 13), ImageFileName = "product5.jpg" },
            new Product() { ProductId = 6, ProductName = "Grandma's Boysenberry Spread", UnitInStock = 5, UnitPrice = 22m, DeliveryOn = new DateTime(2020, 11, 13), ImageFileName = "product6.jpg" },
            new Product() { ProductId = 7, ProductName = "Uncle Bob's Organic Dried Pears", UnitInStock = 22, UnitPrice = 18.9m, DeliveryOn = new DateTime(2020, 11, 13), ImageFileName = "product7.jpg" },
            new Product() { ProductId = 8, ProductName = "Northwoods Cranberry Sauce", UnitInStock = 3, UnitPrice = 15m, DeliveryOn = new DateTime(2020, 11, 22), ImageFileName = "product8.jpg" },
            new Product() { ProductId = 9, ProductName = "Mishi Kobe Niku", UnitInStock = 0, UnitPrice = 21m, DeliveryOn = new DateTime(2020, 11, 22), ImageFileName = "product9.jpg" },
            new Product() { ProductId = 10, ProductName = "Ikura", UnitInStock = 13, UnitPrice = 8m, DeliveryOn = new DateTime(2020, 11, 22), ImageFileName = "product10.png" }
        };

    }
}
