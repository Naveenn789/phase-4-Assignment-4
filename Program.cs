// See https://aka.ms/new-console-template for more information

using ConAppProductsJenkins;

List<Product> products = new List<Product>()
{
    new Product(){PName="Oreo Kit Kat",PBrand=" Nestle",PPrice=120,ManufacturingDate=new DateTime(day:04,month:07,year:2023),ExpiryDate= new DateTime(day:12,month:09,year:2025)},
    new Product(){PName="Wheat Atta",PBrand="Ashirawd",PPrice=273.74,ManufacturingDate=new DateTime(day:11,month:11,year:2023),ExpiryDate= new DateTime(day:23,month:02,year:2024)},
    new Product(){PName="FiveStar Fuse",PBrand="Cadburry",PPrice=75.00,ManufacturingDate=new DateTime(day:19,month:03,year:2021),ExpiryDate= new DateTime(day:02,month:12,year:2026)},
    new Product(){PName="Tublar Battery",PBrand="  Amaron",PPrice=9330.72,ManufacturingDate=new DateTime(day:30,month:12,year:2023),ExpiryDate= new DateTime(day:01,month:12,year:2031)},
    new Product(){PName="Hair Shampoo",PBrand="Head&Sholder",PPrice=220.80,ManufacturingDate=new DateTime(day:15,month:10,year:2023),ExpiryDate= new DateTime(day:31,month:05,year:2025)},

};
Console.WriteLine("Product Name \t Product Brand \t Product Price \t Manufacturing Date \t Expire Date");
foreach (Product p in products)
{
    Console.Write(p.PName+"\t ");
    Console.Write(p.PBrand+"\t");
    Console.Write(p.PPrice+"\t \t");
    Console.Write(p.ManufacturingDate+"\t");
    Console.Write(p.ExpiryDate+"");
    Console.WriteLine("\n");
}
