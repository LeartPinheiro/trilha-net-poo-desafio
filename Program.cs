using DesafioPOO.Models;


Console.WriteLine("Testando Nokia");
Smartphone nokia = new Nokia("2222-2345", "Nokia 2", "8567", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.MostrarInformacoes();

Console.WriteLine("\n");

Console.WriteLine("Testando Iphone");
Smartphone iphone = new Iphone("8888-4567", "Iphone 7", "6785", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");
iphone.MostrarInformacoes();
