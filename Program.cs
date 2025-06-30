using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("iniciando Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 2000", imei: "111111111", memoria: 64);
nokia.MostrarInfo();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.DesligaCelular();
Console.WriteLine("\n");

Console.WriteLine("Iniciando Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "910675", modelo: "modelo 1", imei: "222222222", memoria: 220);
Iphone.MostrarInfo();
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Facebook");
Iphone.DesligaCelular();