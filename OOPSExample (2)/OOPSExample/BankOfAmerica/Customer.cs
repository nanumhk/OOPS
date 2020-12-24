using System;
using System.Collections.Generic;
using System.Text;
using Bank;

//Namespace
namespace Bank
{
    //Enum
    public enum AccountType
    {
        Savings,
        Current
    }
}

//Namespace
namespace BankOfAmerica
{
    //Class
    class Customer
    {
        //Non-Static Data Members
        private string _customerName;
        private string _customerAddress;
        private string _customerPhoneNumber;
        private string _ssn;
        private double _accountBalance;
        private AccountType _accountType;

        //Static Data Memebers
        private static int _customerId = 0;

        //Parameterized Constructor
        public Customer(string customerName, string customerAddress, string customerPhoneNumber, string ssn, double accountBalance, AccountType accountType)
        {
            //Initializing data memebers
            _customerName = customerName;
            _customerAddress = customerAddress;
            _customerPhoneNumber = customerPhoneNumber;
            _ssn = ssn;
            _accountBalance = accountBalance;
            _accountType = accountType;

            //Method call to generate Customer Id for each time object is created
            OriginateCustomerId();
        }

        //Logic to increment Customer Id
        private void OriginateCustomerId()
        {
            _customerId = _customerId + 1;
        }

        //Printing the detials of Customer
        public void GetCustomerDetails()
        {
            Console.WriteLine("Hello " + this._customerName + " your Customer Id is : " + _customerId);
        }
    }
}
