using DesafioPOO.Models;

//OK TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "53778", modelo: "Nokia 3310", imei: "IMEI123456", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "17553",modelo: "iPhone 13",imei: "IMEI987654",memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

