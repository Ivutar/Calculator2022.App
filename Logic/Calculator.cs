namespace Calculator2022.Logic;

public class Calculator
{
    //константы
    public const string Clear = "C";
    public const string BackSpace = "B";
    //...

    //данные (приватные)
    string _screen; //экран калькулятора
    //...

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
        //...
    }

    //"нажатие" на кнопку
    public void Press (string key)
    {
        //...
    }
}
