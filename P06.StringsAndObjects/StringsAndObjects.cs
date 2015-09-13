using System;

//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object a = hello + " " + world;
        string casting = (string)a;
        Console.WriteLine(a + "\n" + casting); //not expected as an output but I've decided, it would be better to print it in the console in order to see it's working.
    }
}

