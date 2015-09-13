using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Amanda";
        string lastName = "Jonson";
        sbyte age = 27;
        char gender = 'f';
        long personalID = 8306112507;
        int uniqueEmployeeNumber = 27563571;

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + personalID);
        Console.WriteLine("Unique Employee Number: " + uniqueEmployeeNumber);
    }
}

// P10: A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// •	First name
// •	Last name
// •	Age (0...100)
// •	Gender (m or f)
// •	Personal ID number (e.g. 8306112507)
// •	Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

// Expected Output
// First name: Amanda
// Last name: Jonson
// Age: 27
// Gender: f
// Personal ID: 8306112507
// Unique Employee number: 27563571