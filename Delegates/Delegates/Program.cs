using Delegates;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("---Працюємо з делегатами---");

//int result = MyCalculator.Add(2, 7);

//Console.WriteLine("a+b = " + result);

/*
//Це делагат який на ні кого не вказує
MyOperationDelegate operation = null;

string action = string.Empty;
Console.Write("Вкажіть, яку операію виконати(+,-) ->_");
action = Console.ReadLine();
if (action.Equals("+"))
    operation = MyCalculator.Add;
else
    operation = MyCalculator.Substract;
int a, b;
Console.Write("Вкажіть a = ");
a = int.Parse(Console.ReadLine());
Console.Write("Вкажіть b = ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Результат = " + operation(a,b));
*/

Car lexus = new Car(220);

lexus.setDisplay(DisplayColors); //кольоровий телевізор
lexus.Gas(20);
lexus.Gas(60);
lexus.Gas(120);
lexus.Gas(230);

Car lanos = new Car(120);
lanos.setDisplay(DisplayMonoChrom);
lanos.Gas(20);
lanos.Gas(60);
lanos.Gas(90);
lanos.Gas(130);

void DisplayMonoChrom(string message)
{
    Console.WriteLine("---Сповіщення---");
    Console.WriteLine(message);
    Console.WriteLine("---Будьте уважні----");
}

void DisplayColors(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("---Сповіщення---");
    Console.WriteLine(message);
    Console.WriteLine("---Будьте уважні----");
    Console.ForegroundColor= ConsoleColor.White;
}
