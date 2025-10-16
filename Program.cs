using DesafioPOO.Models;

namespace DesafioPOO;

internal static class Program
{
    private static void Main()
    {
        Smartphone nokia = new Nokia(numero: "21 988763567", modelo: "Nokia 3310", imei: "351756238452147", memoria: 32);
        Console.WriteLine("### Testando Nokia ###");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        Smartphone iphone = new Iphone(numero: "11 98763487", modelo: "iPhone 14", imei: "994567823541237", memoria: 256);
        Console.WriteLine("### Testando iPhone ###");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
