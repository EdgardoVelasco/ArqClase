// See https://aka.ms/new-console-template for more information
using POO.Herencia;

Console.WriteLine("Hello, World!");

Lavadora lav = new Lavadora();
Electrodomestico el = lav; //promoción
Lavadora lav2 = (Lavadora)el; //Casting