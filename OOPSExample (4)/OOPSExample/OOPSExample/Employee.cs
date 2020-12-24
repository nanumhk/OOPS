using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    //Employee is a Child class of Person class
    //Person is a parent class to Employee class
    class Employee : Person
    {
        //Specific data memebers for Employee
        private string _empId;
        private string _currentCompanyName;
        private string[] _allCompanies;

        //If Parent class has parameterized constructor then it is mandatory to call the parent class parameterized constructor
        //base is a keyword by which we can call parent class constructor
        public Employee(string empId, string currentCompanyName, string[] allCompanies, string name, int age):base(name, age)
        {
            this._empId = empId;
            this._currentCompanyName = currentCompanyName;
            this._allCompanies = allCompanies;
        }

        //Get Employee History is a member funtion
        //Get Employee History is having business logic based on all companies array length of current calling object
        public void GetEmployeeHistory()
        {
            //totalNumberOfCompanies local variable is calculated based on _allCompanies's array length of current calling object
            int totalNumberOfCompanies = this._allCompanies.Length;
            switch(totalNumberOfCompanies)
            {
                case 1:
                    Console.WriteLine(this._name + " has working experince of only " + totalNumberOfCompanies + " company");
                    Console.WriteLine(this._name + "'s Current company name is : " + this._currentCompanyName);
                    break;
                case 2:
                    Console.WriteLine(this._name + " has working experince in " + totalNumberOfCompanies + " companies");
                    Console.WriteLine(this._name + "'s Current company name is : " + this._currentCompanyName);
                    GetAllCompaines();
                    break;
                case 3:
                    Console.WriteLine(this._name + " has working experince in " + totalNumberOfCompanies + " companies");
                    Console.WriteLine(this._name + "'s Current company name is : " + this._currentCompanyName);
                    GetAllCompaines();
                    break;
            }
        }

        //Get All Companies is a member funtion
        public void GetAllCompaines()
        {
            foreach (var company in this._allCompanies)
            {
                if (!company.Equals(this._currentCompanyName))
                    Console.WriteLine(this._name + " has worked in : " + company);
            }
        }
    }
}
