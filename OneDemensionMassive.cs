using System;
using System.Collections;

public sealed class OneDemensionMassive<T>
{
    private T[] massive;
    private Random r = new Random();
    private int len = 10;

    public OneDemensionMassive(Func<T[], bool, T[]> action) 
    {
        CreateMassive(action);
    }

    public void CreateMassive(Func<T[], bool, T[]> action)
    {
        Console.WriteLine("How to fill the array");
        bool choice = bool.Parse(Console.ReadLine());
        if (choice)
        {
            massive = new T[int.Parse(Console.ReadLine())];
        }
        else
        {
            massive = new T[len];
        }
        massive = action(massive, choice);
    }

    public void AddElement(Func<T[], T[]> action)
    {
        massive = action(massive);
    }

    public void Print()
    {
        Console.WriteLine("Massive");
        foreach (T i in massive)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public void DeleteElement(Func<T[], int, T[]> action)
    {
        Console.WriteLine("Write the index of element you will remove");
        int ind = int.Parse(Console.ReadLine());
        massive = action(massive, ind);
    }

    public void Sorting()
    {
        Array.Sort(massive);
    }

    public bool EvenIfOne(Func<T, bool> action)
    {
        foreach (T i in massive)
        {
            if (action(i))
            {
                return true;
            }
        }
        return false;
    }
    public bool IfAll(Func<T, bool> action)
    {
        foreach (T i in massive)
        {
            if (!action(i))
            {
                return false;
            }
        }
        return true;
    }

    public void CountWithIf(Func<T, bool> action)
    {
        int c = 0;
        foreach(T i in massive)
        {
            if(action(i)){
                c++;
            }
        }
        Console.WriteLine(c);
    }

}