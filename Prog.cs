using System;

class Prog{
    static void Main()
    {
        Random r = new Random();
        OneDemensionMassive<int> intArray = new OneDemensionMassive<int>((m, b) =>
        {
            int[] mass = new int[m.Length];
            if (b)
            {
                for(int i = 0; i < mass.Length; i++){
                    mass[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = r.Next(-1000, 1000);
                }
            }
            return mass;
        });
        intArray.Print();
        OneDemensionMassive<double> doubleArray = new OneDemensionMassive<double>((m, b) =>
        {
            double[] mass = new double[m.Length];
            if (b)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = double.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = r.Next(-1000, 1000)/r.Next(-10, 10);
                }
            }
            return mass;
        });
        doubleArray.Print();
        intArray.AddElement((m)=>
        {
            int[] mass = new int[m.Length+1];
            for (int i = 0; i < m.Length; i++)
            {
                mass[i] = m[i];
            }
            mass[m.Length] = r.Next(-1000, 1000);
            return mass;
        });
        intArray.Print();
        doubleArray.AddElement((m) =>
        {
            double[] mass = new double[m.Length + 1];
            for (int i = 0; i < m.Length; i++)
            {
                mass[i] = m[i];
            }
            mass[m.Length] = r.Next(-1000, 1000) / r.Next(-10, 10);
            return mass;
        });
        doubleArray.Print();
        intArray.DeleteElement((m,i)=>
        {
            int[] mass = new int[m.Length-1];
            for (int t = 0; t<m.Length; t++)
            {
                if(t<i)
                {
                    mass[t] = m[t];
                }
                else if(t>i)
                {
                    mass[t-1] = m[t];
                }
            }
            return mass;
        });
        intArray.Print();
        doubleArray.DeleteElement((m, i) =>
        {
            double[] mass = new double[m.Length - 1];
            for (int t = 0; t < m.Length; t++)
            {
                if (t < i)
                {
                    mass[t] = m[t];
                }
                else if (t > i)
                {
                    mass[t - 1] = m[t];
                }
            }
            return mass;
        });
        doubleArray.Print();
        intArray.Sorting();
        intArray.Print();
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