using System;

// P11: A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Kostadinov";
        string lastName = "Stoyanov";
        decimal balance = 4098987.89M; //the balance should be a decimal variable in order the information to be precise at any moment.
        string bankName = "Unicredit Bulbank";
        string iBAN = "BG29UNCR70001111711111";
        long creditCard1 = 4563960122019991;
        long creditCard2 = 6563960123319871;
        long creditCard3 = 7863960134569892;

        Console.WriteLine("Information about Personal Bank Account: " + "\n" + "First Name: " + firstName);
        Console.WriteLine("Middle Name: " + middleName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Account Balance: " + balance);
        Console.WriteLine("Bank: " + bankName);
        Console.WriteLine("IBAN: " + iBAN);
        Console.WriteLine("Number of active credit cards: " + "\n" + "{0}\n{1}\n{2}", creditCard1, creditCard2, creditCard3);
    }
}

