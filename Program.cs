using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone ip = new Iphone("859897866", "Modelo k", "12313123", 8);
ip.Ligar();
ip.ReceberLigacao();
ip.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia");
Smartphone nk = new Nokia("94857866", "Modelo j", "22323233", 6);
nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("Youtube");