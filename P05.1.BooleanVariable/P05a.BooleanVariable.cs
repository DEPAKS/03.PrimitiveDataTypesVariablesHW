
//Found another intresting way to use the boolean variable, no matter the output is not as the expeced one. Just wanted to show it and have it for myself too.

using System;

class P05aBooleanVariable

{
    static void Main()
    {
        bool isFemale = false;
        Console.WriteLine("Are you a female? Yes/No: ");
        String answer = Console.ReadLine();
        if (answer == "Yes")
        {
            isFemale = true;
            Console.WriteLine(isFemale);
        }
        else if (answer == "No")
        {
            isFemale = false;
            Console.WriteLine(isFemale);
        }
        else 
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

