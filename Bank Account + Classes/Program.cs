using System;

namespace Bank_Account___Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount Account = new BankAccount("Nick", 100000);

            Console.WriteLine($"{Account.Owner} Has {Account.Balance} in his balance");




        }
    }
}
