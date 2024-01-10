// See https://aka.ms/new-console-template for more information

using ConAppProductsJenkins;

SortedList<int,Product> products = new SortedList<int,Product>()
{ };
products.Add(1, new Product() { PName = "Oreo Kit Kat", PBrand = " Nestle", PPrice = 120, ManufacturingDate = new DateTime(day: 04, month: 07, year: 2023), ExpiryDate = new DateTime(day: 12, month: 09, year: 2025) });
    products.Add(2, new Product(){PName="Wheat Atta",PBrand="Ashirawd",PPrice=273.74,ManufacturingDate=new DateTime(day:11,month:11,year:2023),ExpiryDate= new DateTime(day:23,month:02,year:2024)});
products.Add(3, new Product() { PName = "FiveStar Fuse", PBrand = "Cadburry", PPrice = 75.00, ManufacturingDate = new DateTime(day: 19, month: 03, year: 2021), ExpiryDate = new DateTime(day: 02, month: 12, year: 2026) });
products.Add(4, new Product() { PName = "Tublar Battery", PBrand = "  Amaron", PPrice = 9330.72, ManufacturingDate = new DateTime(day: 30, month: 12, year: 2023), ExpiryDate = new DateTime(day: 01, month: 12, year: 2031) });
products.Add(5, new Product() { PName = "Hair Shampoo", PBrand = "Head&Sholder", PPrice = 220.80, ManufacturingDate = new DateTime(day: 15, month: 10, year: 2023), ExpiryDate = new DateTime(day: 31, month: 05, year: 2025) });


Console.WriteLine("Index Value \t Product Name \t Product Brand \t Product Price \t Manufacturing Date \t Expire Date");
foreach (var p in products)
{
    Console.Write(p.Key+"\t \t");
    Console.Write(p.Value.PName+"\t ");
    Console.Write(p.Value.PBrand+"\t");
    Console.Write(p.Value.PPrice+"\t \t");
    Console.Write(p.Value.ManufacturingDate+"\t");
    Console.Write(p.Value.ExpiryDate+"");
    Console.WriteLine("\n");
}
