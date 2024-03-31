using System;

class Prog{
    static void Main()
    {
        OneDemensionMassive<int> intArray = new();
        intArray.Print();
        OneDemensionMassive<double> doubleArray = new();
        doubleArray.Print();
        intArray.Add(5);
        intArray.Add(25);
        intArray.Add(453);
        intArray.Add(4354);
        intArray.Add(75373);
        intArray.Add(15);
        intArray.Print();
        doubleArray.Add(874.44);
        doubleArray.Add(701.25);
        doubleArray.Add(942.5);
        doubleArray.Add(0.241);
        doubleArray.Add(0.5);
        doubleArray.Add(94);
        doubleArray.Add(6.4);
        doubleArray.Print();
        intArray.DeleteElement(2);
        intArray.Print();
        doubleArray.DeleteElement(6);
        doubleArray.Print();
        intArray.Sorting();
        intArray.Print();
        doubleArray.Sorting();
        doubleArray.Print();
        Console.WriteLine(intArray.MaxValue());
        Console.WriteLine(intArray.MinValue());
        Console.WriteLine(doubleArray.MaxValue());
        Console.WriteLine(doubleArray.MinValue());
    }
}