using System;

namespace laba_4;
class Program4
{
    static void Main(string[] args)
    {
        PartialClass partialClass = new PartialClass("Ivan", "Ivanov");
        partialClass.Print();
        Point first = new(1, 3);

        first.Print();

        Test test_first = new("Test", 1);
        Test test_second = new("Test", 2);
        Test test_third = new("Test", 3);

        short a = short.MaxValue;
        Console.WriteLine(a);
        string[] arr = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь" };
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
       
    }
}

class Card : IMinus, IPlus
{
    public string _month { get; set; }
    public string _year { get; }
    public int _balance { get; set; }

    public string Month
    {
        get
        {
            return _month;
        }
        set
        {
            if (value != _month)
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _month = value;
                }
                else if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(Month)} не может быть null", nameof(Month));
                }
                else
                {
                    throw new ArgumentException($"{nameof(Month)} не может быть пустой или содержать только пробелы", nameof(Month));
                }
            }
        }
    }


    public string Year
    {
        get
        {
            return _year;
        }
    }

    public int Balance
    {
        get
        {
            return _balance;
        }
        set
        {
            _balance = value;
        }
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    void IPlus.MakeTransactions() { Console.WriteLine( _balance + 25); }
    void IMinus.MakeTransactions() {Console.WriteLine(_balance - 25); }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}

   

class CardWithHistory : Card
{

}

   
    


interface IMinus
{
    void MakeTransactions();
}

interface IPlus
{
    void MakeTransactions();
}