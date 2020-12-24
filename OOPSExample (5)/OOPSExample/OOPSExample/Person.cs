using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    //Parent Class to Employee and Teacher classes
    //Generailezed data member and member funtions
    class Person
    {
        //Name and Age are data members at parent class level
        //It is having access specifier as protected
        //All Child classes can access Name and Age data members
        protected string _name;
        protected int _age;

        //Default Constructor
        //public Person()
        //{
        //    this._name = "xyz";
        //    this._age = 21;
        //}

        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        //Get Age is a memeber funtion
        //Get Age is having business logic based on age of current calling object's age
        public void GetAge()
        {
            switch (this._age)
            {
                case 30:
                    Console.WriteLine(this._name + " is young");
                        break;
                case 40:
                    Console.WriteLine(this._name + " is in his mid age");
                    break;
                case 50:
                    Console.WriteLine(this._name + " is senior");
                    break;
                default:
                    Console.WriteLine(this._name + " is of age : " + this._age);
                    break;
            }
        }

        //Get Name is a memeber funtion
        public void GetName()
        {
            Console.WriteLine("Name is : " + this._name);
        }
    }
}
