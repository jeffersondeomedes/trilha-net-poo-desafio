using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "876633", modelo: "C2232", imei: "1110010101110", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "5432323", modelo: "8 PLUS", imei: "233332323232", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("LinkedIn");