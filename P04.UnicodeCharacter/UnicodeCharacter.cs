﻿using System;

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. 
// Expected Output:
// *

class UnicodeCharacter
{
    static void Main()
    {
        char uniCode = '\u002A';

        Console.WriteLine(uniCode);
    }
}

