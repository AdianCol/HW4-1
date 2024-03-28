using System;

class Prog{
    static void Main()
    {
        OneDemensionMassive<int> intArray = new();
        intArray.Print();
        OneDemensionMassive<double> doubleArray = new();
        doubleArray.Print();
        intArray.Add(5);
        intArray.Print();
        doubleArray.Add(6.4);
        doubleArray.Print();
        intArray.DeleteElement(2);
        intArray.Print();
        doubleArray.DeleteElement(6);
        doubleArray.Print();
        intArray.Sorting();
        intArray.Print();A
        doubleArray.Sorting();
        doubleArray.Print();
        intArray.CountWithIf((i)=>
        {
            if(i>50){
                return true;
            }
            else{
                return false;
            }
        });
        doubleArray.CountWithIf((i) =>
        {
            if (i < -60.7)
            {
                return true;
            }
            else
            {
                return false;
            }
        });
        Console.WriteLine(intArray.EvenIfOne((i)=>
        {
            if (i<10)
                {return true;}
            else
                {return false;}
        }));
        Console.WriteLine(doubleArray.EvenIfOne((i) => { if (i < 0) { return true;} else { return false;} }));
        Console.WriteLine(intArray.IfAll((i) => { if (i > 10) { return true; } else { return false; } }));
        Console.WriteLine(doubleArray.IfAll((i) => { if (i > 0) { return true; } else { return false; } }));

    }
}