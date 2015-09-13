using System; 
// P12: Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine(a);
        a += 53; //adds 53 to the value of the variable
        Console.WriteLine(a);
        //a = 10; //If "a" is = 10, in this case it will print 10 in the console. But it's not part of the problem and the expected output.
        //Console.WriteLine(a);

        Console.WriteLine(b);
        b += 73; //adds 73 to the value of the variable
        Console.WriteLine(b);
        //b = 11; //If "b" is = 11, in this case it will print 11 in the console. But it's not part of the problem and the expected output.
        //Console.WriteLine(b);
    }
}
