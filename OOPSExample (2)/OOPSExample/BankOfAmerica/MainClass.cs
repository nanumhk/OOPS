using System;
using Bank;

namespace BankOfAmerica
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Bank bank = new Bank("XYZ", "123S", "1234567890");
            //Console.WriteLine("Enter Customer Name");
            //Console.WriteLine("Enter Customer Name"); 
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter loan Amount");
            //double amount = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Yearly Income");
            //double income = Convert.ToDouble(Console.ReadLine());

            //bank.GenerateLoan(name, amount, income);

            Customer customer1 = new Customer("Vaibhav", "ABC", "9876543210", "12345", 50, AccountType.Savings);
            customer1.GetCustomerDetails();

            Customer customer2 = new Customer("Chandra", "XYZ", "0123456789", "54321", 100, AccountType.Current);
            customer2.GetCustomerDetails();
        }
    }
}
