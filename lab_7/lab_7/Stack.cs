﻿
using System.IO;
using System.Text.Json;

namespace laba_7;

class CollectionType<T> : IStack<T>
  where T : IComparable

{

    #region Fields
    private const string File_name = "Stack.json";
    private T[] stack;
    private int top;
    private int size;
    #endregion

    #region Constructors
    public CollectionType(int size)
    {

        this.size = size;
        stack = new T[size];
        top = -1;



    }
    #endregion

    #region Properties
    public T[] AllElements
    {
        get
        {
            T[] allElements = new T[top + 1];
            Array.Copy(stack, allElements, top + 1);
            return allElements;
        }

    }
    #endregion

    #region Methods

    /// <summary>
    /// Добавить элемент в стек
    /// </summary>
    public void Push(T item)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack is full");
            return;
        }
        stack[++top] = item;
    }

    public static CollectionType<T> operator +(CollectionType<T> stack, T element)
    {
        stack.Push(element);
        return stack;
    }


    public void Sort()
    {
        Array.Sort(stack);
        Print();
    }
    /// <summary>
    /// Извлечь элемент
    /// </summary>
    public T Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return default(T);

        }
        return stack[top--];
    }

    public static CollectionType<T> operator --(CollectionType<T> stack)
    {
        stack.Pop();
        return stack;
    }

    public static bool operator true(CollectionType<T> stack)
    {
        if (stack.top == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator false(CollectionType<T> stack)
    {
        if (stack.top == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static CollectionType<T> operator >(CollectionType<T> stack1, CollectionType<T> stack2)
    {
        for (int i = 0; i < stack1.size; i++)
        {
            stack2.stack[i] = stack1.stack[i];
        }
        Array.Sort(stack2.stack);
        return stack2;
    }
    public static CollectionType<T> operator <(CollectionType<T> stack1, CollectionType<T> stack2)
    {
        for (int i = 0; i < stack1.size; i++)
        {
            stack2.stack[i] = stack1.stack[i];
        }
        Array.Sort(stack2.stack);
        Array.Reverse(stack2.stack);
        return stack2;
    }

    public int CountSentences()
    {
        int count = 0;
        for (int i = 0; i < stack.Length; i++)
        {
            if (
                stack[i].ToString().Contains(".") ||
                stack[i].ToString().Contains("!") ||
                stack[i].ToString().Contains("?")
                )
            {
                count++;
            }

        }
        return count;

    }
    public static T MiddleElement(CollectionType<T> stack)
    {
        int middle = stack.size / 2;
        return stack.stack[middle];
    }

    /// <summary>
    /// Вывод на экран
    /// </summary>
    public void Print()
    {
        for (int i = 0; i < top + 1; i++)
        {
            Console.WriteLine(stack[i]);
        }
    }

    public void Pushs(params T[] elements)
    {
        foreach (T element in elements)
        {
            Push(element);
        }
    }

    /*5. Добавьте методы сохранения объектов обобщённого типа
CollectionType<T> в файл и чтения из него ( на выбор: текстовый | xml | json). */
    public void PushToFile()
    {
        using StreamWriter sw = new(File_name);
        var str = JsonSerializer.Serialize(stack);
        sw.WriteLine(str);

    }

    public void ReadFromFile()
    {
        using StreamReader sr = new(File_name);
        var str = sr.ReadToEnd();
        stack = JsonSerializer.Deserialize<T[]>(str);
    }

    #endregion
}


//Создайте обобщенный интерфейс с операциями добавить, удалить ,просмотреть. 

interface IStack<T>
{
    void Push(T item);
    T Pop();
    void Print();
}








