using System;


 namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        { 
            var bankAccount = new BankAccount();
            Console.WriteLine("How much money are you looking to deposit?");
            double input = Convert.ToDouble(Console.ReadLine());
            bankAccount.Deposit(input);

            Console.WriteLine($"Your current balance is:{bankAccount.GetBalance()}");

        }
    }
}
