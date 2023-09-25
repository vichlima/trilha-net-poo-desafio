using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero:"123456", Modelo: "modelo 1", IMEI:"11111111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new iPhone(numero: "45678", Modelo: "modelo 2", IMEI: "222222222", Memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");