using System.Text;

namespace ExampleLambda;

class Program
{
    public delegate void MessageDelegate(string text); //наш делегат

    private static MessageDelegate displayInfo;

    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("---Працюємо із подіями та Лямбда виразами---");
        displayInfo = MyDisplayOled;
        displayInfo("-Потрібно заправити бака-");
    }

    public static void MyDisplayOled(string msg)
    {
        Console.WriteLine("-------");
        Console.WriteLine(msg);
        Console.WriteLine("-------");
    }
}


