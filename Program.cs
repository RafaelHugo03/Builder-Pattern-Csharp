// See https://aka.ms/new-console-template for more information


using BuilderDP.Builders;
using BuilderDP.Directors;
using BuilderDP.Products;

VehicleBuilders builder = new VehicleBuilders();

Director director = new Director(builder);

director.ConstructSedan();

Vehicle sedan = builder.GetVehicle();

Console.WriteLine($"Seu carro é um {sedan.VehicleType}");

var suvBuilder = new SUVbuilder();
var director2 = new Director(suvBuilder);

director2.ConstructSUV();

SUV suv = (SUV)suvBuilder.GetVehicle();

Console.WriteLine($"Seu carro é um {suv.VehicleType}");


