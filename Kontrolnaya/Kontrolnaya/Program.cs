using System;

namespace kr;

class Program
{
    static void Main(string[] args)
    {
        //1 A)
        float min = float.MinValue;
        float max = float.MaxValue;
        Console.WriteLine("от {0} до {1}", min, max);
        //1 Б)
        string str = "Hello world, my name is artyom";
        Console.WriteLine(str);
        str = str.Replace('o', 'a');
        str = str.Replace('i', 'e');
        Console.WriteLine(str);

        object[] OBJ = { new RAM(), new RAM(), new Paper(), new Paper(), new Memory(), new Memory() };
    }
}

class Shop
{
    public string[] Goods { get; set; }

    public string[] goods
    {
        get
        {
            return Goods;
        }
        set
        {
            Goods = value;
        }
    }
    public Shop(string[] goods)
    {
        Goods = goods;
    }

    class Good
    {
        
        Good[] goods = new Good[5];
       
    }

    public Shop()
    {
        for (int i = 0; i < Goods.Length; i++)
        {
            Goods[i] = "Undefined";
        }
       
    }
    public void Print()
    {
        for (int i = 0; i < Goods.Length; i++)
        {
            Console.WriteLine($"{ Goods[i]}");
        }
        
    }
}


class RAM : ISendable
{
    public RAM()
    {

    }

    public void ToSend(string a)
    {
        Console.WriteLine("метод ToSend");
    }
}

class Memory
{

}

class Paper : ISendable
{
    public Paper()
    {

    }

    public void ToSend(string a)
    {
        Console.WriteLine(a);
    }
}

interface ISendable
{
    void ToSend(string a);
}