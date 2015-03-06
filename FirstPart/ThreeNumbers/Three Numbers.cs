
using System;

class ThreeNumbers
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        double biggestNumber = double.MinValue;
        double smallestnumber = double.MaxValue;
        double arithmetic = 0;
       
        if (numberA >= numberB && numberA >= numberC)
        {
           biggestNumber =  numberA;
        }
        else if (numberB >= numberA && numberB >= numberC)
        {
            biggestNumber = numberB; 
        }
        else if (numberC >= numberA && numberC >= numberB)
        {
            biggestNumber = numberC;
        }
        if (numberA <= numberB && numberA <= numberC)
        {
            smallestnumber = numberA;
        }
        else if (numberB <= numberA && numberB <= numberC)
        {
            smallestnumber = numberB;
        }
        else if (numberC <= numberA && numberC <= numberB)
        {
            smallestnumber = numberC;
        }
        arithmetic = (numberA + numberB + numberC) / 3;
       
        Console.WriteLine(biggestNumber);
        Console.WriteLine(smallestnumber);
        Console.WriteLine("{0:F2}", arithmetic );
    }
}         	       
            

