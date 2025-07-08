using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("11555555555", "Nokia G11 Plus", "1234567890", 256);
        Smartphone iphone = new Iphone("11777777777", "iPhone 12", "0987654321", 128);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");

        Console.WriteLine(); // pular uma linha

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}