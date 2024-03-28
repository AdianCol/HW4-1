using System;
using System.Collections;

public sealed class OneDemensionMassive<T>
{
    private T[] massive;
    private Random r = new Random();
    private int _size;
    private int _capacity;

    public OneDemensionMassive(int capacity) 
    {
        massive = new T[capacity];
        _capacity = capacity;
        _size = 0;
    }

    public OneDemensionMassive():this(7)
    {}

    public void Add(T element)
    {
        if(_size>=_capacity)
        {
            _capacity = 2 * _capacity + 1;
            T[] mass = new T[_capacity];
            Array.Copy(massive, mass,_size);
            massive = mass;
        }
        massive[_size] = element;
        _size++;
    }

    public void Print()
    {
        Console.WriteLine("Massive");
        for (int i = 0; i<_size; i++)
        {
            Console.Write(massive[i] + " ");
        }
        Console.WriteLine();
    }

    public void DeleteElement(int index)
    {
        if(index<=_size)
        {
            T[] mass = new T[_capacity];
            for (int t = 0; t < _size; t++)
            {
                if (t != index)
                {
                    mass[t] = massive[t];
                }
            }
            _size--;
            massive = mass;
        }
        else
        {
            Console.WriteLine("Index is out of range!");
        }
    }

    public void Sorting()
    {
        Array.Sort(massive, 0, _size);
    }

    public bool EvenIfOne(Func<T, bool> action)
    {
        for (int i = 0; i < _size; i++)
        {
            if (action(massive[i]))
            {
                return true;
            }
        }
        return false;
    }
    public bool IfAll(Func<T, bool> action)
    {
        for (int i = 0; i < _size; i++)
        {
            if (!action(massive[i]))
            {
                return false;
            }
        }
        return true;
    }

    public void CountWithIf(Func<T, bool> action)
    {
        int c = 0;
        for(int i = 0; i<_size; i++)
        {
            if(action(massive[i])){
                c++;
            }
        }
        Console.WriteLine(c);
    }

}