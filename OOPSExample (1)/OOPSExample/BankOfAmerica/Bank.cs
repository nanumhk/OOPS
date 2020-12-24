using System;
using System.Collections.Generic;
using System.Text;

//Namespace
namespace BankOfAmerica
{
    //Class Bank
    class Bank
    {
        //Non-Static Data Memebers
        private string _bankAddress;
        private string _sWIFTCode;
        private string _bankPhoneNumber;

        //Parameterized Constructor
        public Bank(string bankAddress, string sWIFTCode, string bankPhoneNumber)
        {
            this._bankAddress = bankAddress;
            this._sWIFTCode = sWIFTCode;
            this._bankPhoneNumber = bankPhoneNumber;
        }

        //Member Function
        public void GenerateLoan(string customerName, double loanAmount, double customerIncome)
        {
            //Method call
            bool isEigible = IsCustomerEligibleForLoan(loanAmount, customerIncome);
            if (isEigible)
            {
                Console.WriteLine(customerName + " are eligible to get loan");
            }
            else
            {
                Console.WriteLine(customerName + " are not eligible to get loan");
            }
        }

        //Logic for customer is eligible for loan
        private bool IsCustomerEligibleForLoan(double loanAmount, double customerIncome)
        {   
            double approvedLoanAmount = (customerIncome * 0.6);
            if (approvedLoanAmount > loanAmount)
                return true;
            else
                return false;

            //Another way to achive the same funtionality
            /*bool status = false;
            double approvedLoanAmount = (customerIncome * (60 / 100));
            if (approvedLoanAmount > loanAmount)
                status = true;

            return status;*/
        }
    }
}
