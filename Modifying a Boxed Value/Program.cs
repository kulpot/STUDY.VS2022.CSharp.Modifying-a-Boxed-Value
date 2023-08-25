using System;

//ref link:https://www.youtube.com/watch?v=Js1JN4D8igM&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=13
//

struct Fraction
{
    int numerator;
    int denominator;
}

class MainClass
{
    static void Main()
    {
        //object o = 5;
        //object anotherO = 0;
        //int temp = ((int)o);
        //o = temp + 1;

        //////////

        Fraction myFrac = new Fraction();
        object o = myFrac;
        Fraction anotherFrac = (Fraction)myFrac;
    }
}