using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;

        Console.WriteLine("Before:" + "\n" + "a = " + a + "\n" + "b = " + b);
        if (b > a)
        {
            c = b;
            b = a;
            a = c;
            Console.WriteLine("Äfter: " + "\n" + "a = " + a + "\n" + "b = " + b);
        }
        else
        {
            Console.WriteLine("a = {0} and b = {1}", a, b);
        }
    }
}


// P09: Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.
// Expected Output
// Before:
// a = 5
// b = 10
// After:
// a = 10
// b = 5
