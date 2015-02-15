using System;

class BankAccount
{
    //14.A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
    //  bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
    //  to keep the information for a single bank account using the appropriate data types and descriptive names.
    static void Main()
    {
        Console.WriteLine(" Personal Information:");
        string firstName = "Koko";
        string middleName = "Jokov";
        string lastName = "Mokov";
        object fullName = "   " + firstName + " " + middleName + " " + lastName;
        Console.WriteLine(fullName);
        Console.WriteLine();

        Console.WriteLine(" Amount Information:");
        decimal balance = 5023.5M;
        string bankName = "Bulbank";
        string IBAN = "CB 56 AAAA 0000 0123 4567 89";
        string bicCode = "BUINBGSF";
        Console.WriteLine("   {0} has a balance of ({1}) euro.\n   IBAN ({2}) and BIC code ({3})", bankName, balance, IBAN, bicCode);
        Console.WriteLine();

        Console.WriteLine(" Credit Cards:");
        long firstCreditCard = 4207670054361434;
        long secondCreditCard = 4328810002719770;
        long thirdCreditCard = 5466160175050358; 
        Console.WriteLine("   First credit card number  ({0})\n   Second credit card number ({1})\n   Third credit card number  ({2})", 
            firstCreditCard, secondCreditCard, thirdCreditCard);
        Console.WriteLine();
    }
}