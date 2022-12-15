using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "19996739228", modelo: "Tijolão 1995", imei: "123456789-0", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Cobrinha (SNAKE)");

Console.WriteLine("---------------------------------");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "19996739226", modelo: "14 PRO MAX", imei: "098765432-1", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Waze");
