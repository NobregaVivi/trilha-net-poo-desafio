using System.ComponentModel;
using DesafioPOO.Models;



// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "654321", modelo: "a", imei: "1111111111", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n*");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "x", imei: "1111111111", memoria: "64");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

