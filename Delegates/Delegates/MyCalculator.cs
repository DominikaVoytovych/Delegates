namespace Delegates;

public delegate int MyOperationDelegate(int a, int b);
public class MyCalculator
{
    //статичні методи класу
    //Це методи, які можна  викликати без створення
    //самого об'єкта

    public static int Add(int x, int y)
    {
        return x + y;
    }

    //Новий спосіб запису
    public static int Substract(int x, int y) => x - y;
}
