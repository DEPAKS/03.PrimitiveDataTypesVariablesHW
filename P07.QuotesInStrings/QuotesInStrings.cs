using System;

// Declare two string variables and assign them with following value:
// The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.
// Expected Output:
// The "use" of quotations causes difficulties.
// The "use" of quotations causes difficulties.

class QuotesInStrings
{
    static void Main()
    {
        string a = "The \"use\" of quotations causes difficulties.";     //only \ before each "".
        string b = @"The ""use"" of quotations causes difficulties.";   //@ and double "".

        Console.WriteLine(a + "\n" + b);
    }
}

