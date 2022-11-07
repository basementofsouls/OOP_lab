using System;
namespace laba_3;
//   new
// region
// summary
// params
// (this.FIO, this.ID, this.Division) = (FIO, ID, Division);
//_Set - поля

class Program
{
    static void Main(string[] args)
    {
        #region Task_first
        Stack<int> stack = new(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Pop();
        stack.Pop();

        stack += 32;
        stack += 12;
        stack--;


        stack.Print();

        Console.WriteLine("\n\n-----------------------------\n\n");
        Console.WriteLine("Sum: " + StatisticOperation.Sum(stack));
        stack.Print();


        Stack<int> stack2 = new(5);
        stack2.Push(6);
        stack2.Push(7);
        stack2.Push(8);
        stack2.Push(9);
        stack2.Push(10);
        stack = stack > stack2;
        stack = stack < stack2;
        Stack<string> stack3 = new Stack<string>(3);
        stack3.Push("String 1.");
        stack3.Push("String 2.");
        stack3.Push("String 3.");
        int count = stack3.CountSentences();
        Console.WriteLine("Sentences:{0}", count);
        #endregion

        #region Task_second
        Production production = new Production();
        production.Id = 1;
        production.Name = "Гусеничный трактор";
        Console.WriteLine(production.Id);
        Console.WriteLine(production.Name);


        Production.Developer developer = new Production.Developer();
        developer.FIO = "Неважнов Артем Артёмович";
        developer.Id = 1;
        developer.Department = "Информационные технологии";
        Console.WriteLine(developer.FIO);


        StatisticOperation.Sum(stack);
        #endregion
    }

}