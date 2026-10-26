using System.ComponentModel;

namespace Delegates;

public delegate void DisplayDelegate(string message);
public class Car
{
    private DisplayDelegate _display = null;
    public int _currSpeed = 0;
    private int _maxSpeed;

    public Car(int maxSpeed)
    {
        _maxSpeed = maxSpeed;
    }

    //Всановлюємо телевізора
    public void setDisplay(DisplayDelegate display) => _display = display;

    public void Gas(int addSpeed)
    {
        int newSpeed = _currSpeed + addSpeed;
        if(newSpeed > _maxSpeed)
        {
            _currSpeed = _maxSpeed;
            if(_display!= null)
            {
                _display($"Ви досягти максимальної швидкості {_maxSpeed}");
            }
        }
        else
            _currSpeed += addSpeed;
    }

}
