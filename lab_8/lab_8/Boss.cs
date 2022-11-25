namespace laba_8;
/*Создать класс Boss с событиями Upgrade и Turn-on (под 
определенным напряжением, учтите что техника или человек могут 
сломаться). В main создать некоторое количество объектов (техники 
или полу-техники). Подпишите объекты на события произвольным 
образом. Реакция на события у разных объектов будет разная. 
Проверить результаты изменения состояния объектов после 
наступления событий, возможно не однократном*/

class Boss
{
    #region delegate
    public delegate void MyDelegate(string message);

    public event MyDelegate UpgradeAndTurnOn;
    #endregion

    #region Fields
    private string _name;
    private int _voltage;
    #endregion

    #region Constructors

    public Boss(string name, int voltage)
    {
        _name = name;
        _voltage = voltage;
    }
    #endregion

    #region Methods

    public void IncreaseTheVoltage(int vol)
    {
        if (vol > _voltage)
        {
            _voltage = vol;
            UpgradeAndTurnOn?.Invoke("The voltage has increased");
        }

        else
        {
            Console.WriteLine("The voltage is already high enough");
        }
    }
    public void DecreaseTheVoltage(int vol)
    {
        if (vol < _voltage)
        {
            _voltage = vol;
            UpgradeAndTurnOn?.Invoke(" The voltage has decreased");
        }

        else
        {
            Console.WriteLine("The voltage is already low enough");
        }


    }
    public void TurnOn()
    {
        _voltage = 220;
        Console.WriteLine($"The voltage {_voltage} is turned on");

    }


    public override string ToString()
    {
        return $"Name: {_name}, Voltage: {_voltage}";
    }


    #endregion

}

/*  2. Создайте пять методов пользовательской обработки строки (например,
удаление знаков препинания, добавление символов, замена на заглавные, 
удаление лишних пробелов и т.п.). Используя стандартные типы делегатов 
(Action, Func, Predicate) организуйте алгоритм последовательной обработки 
строки написанными вами методами. Далее приведен перечень заданий.
*/

class ChangeString
{
    #region Static methods
    public static string Lower(string str)
    {
        Console.WriteLine("Lower - " + str.ToLower());
        return str.ToLower();
    }

    public static string Upper(string str)
    {
        Console.WriteLine("Upper - " + str.ToUpper());
        return str.ToUpper();
    }

    public static string Remove(string str)
    {
        Console.WriteLine("Remove - " + str.Remove(0, 1));
        return str.Replace(" ", "");
    }

    public static string Add(string str) => str + "!";

    #endregion

}