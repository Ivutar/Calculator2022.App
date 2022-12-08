namespace Calculator2022.Logic;

public class Calculator
{
    //константы
    const int INPUT1 = 1;
    const int OPERATION = 2;
    const int INPUT2 = 3;
    const int RESULT = 4;
    const int ERROR = 5;

    public const string Clear = "C";
    public const string BackSpace = "B";
    //...

    //данные (приватные)
    string _screen; //экран калькулятора
    string _memory;
    string _op;
    int _state;

    //публичные методы
    //получить "содержимое" экрана
    public string Screen
    {
        get { return _screen; }
    }

    //конструктор
    public Calculator()
    {
        _screen = "0";
        _memory = "";
        _op = "";
        _state = INPUT1;
    }

    //"нажатие" на кнопку
    public void Press (string key)
    {
        if (key == Clear)
        {
            _screen = "0";
            _state = INPUT1;
        }
        //...
    }
}
