using System;
using System.Collections;

public sealed class OneDemensionMassive<T>
{
    private T[] massive;
    public int Length {get{return _size;} set{} }
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
                if (t < index)
                {
                    mass[t] = massive[t];
                }
                else if (t > index)
                {
                    mass[t-1] = massive[t];
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

    public void ApplyToAll(Func<T, T> action)
    {
        for(int i =0; i<_size; i++)
        {
            massive[i] = action(massive[i]);
        }
    }

    public T MinValue()
    {
        T[] values = new T[_size];
        for (int i = 0; i < _size; i++)
        {
            values[i] = massive[i];
        }
        Array.Sort(values);
        return values[0];
    }

    public T MaxValue()
    {
        T[] values = new T[_size];
        for (int i = 0; i < _size; i++)
        {
            values[i] = massive[i];
        }
        Array.Sort(values);
        return values[_size-1];
    }

    public void Reverse()
    {
        T[] values = new T[_size];
        int c =0;
        for (int i = _size; i >0; i--)
        {
            values[c] = massive[i];
            c++;
        }
        for (int i = 0; i < _size; i++)
        {
            massive[i] = values[i];
        }
    }

    public T[] ReturnAllWithIf(Func<T, bool> action)
    {
        T[] values = new T[CountWithIf(action)];
        int c = 0;
        for (int i = 0; i < _size; i++)
        {
            if (action(massive[i]))
            {
                values[c] = massive[i];
                c++;
            }
        }
        return values;
    }

    public T ReturnFirstIf (Func<T, bool> action)
    {
        for (int i = 0; i < _size; i++)
        {
            if (action(massive[i]))
            {
                return massive[i];
            }
        }
        return default(T);
    }

    public bool DoesElementExist(T element)
    {
        if(massive.Contains(element))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int CountWithIf(Func<T, bool> action)
    {
        int c = 0;
        for(int i = 0; i<_size; i++)
        {
            if(action(massive[i])){
                c++;
            }
        }
        return c;
    }

}