using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    class Dog
    {
        private string _name;
        private string _color;
        private int _nails;
        private double _weight;
        private double _height;
        private string _breed;
        private bool _tail;
        private int _ears = 2;
        private int _legs = 4;

        public Dog()
        {
            this._name = "XYZ";
            this._color = "Black";
            this._nails = 20;
            this._weight = 25.5;
            this._height = 3.4;
            this._breed = "Local";
            this._tail = true;
        }

        //Constructor
        public Dog(string name, double weight, bool tail)
        {   
            this._name = name;
            this._weight = weight;
            this._tail = tail;
        }

        public Dog(string name, double weight, bool tail, string breed)
        {
            this._name = name;
            this._weight = weight;
            this._tail = tail;
            this._breed = breed;
        }

        public void SetDogDetails(string name, double weight)
        {
            _name = name;
            _weight = weight;
        }

        public void GetDogDetails()
        {
            Console.WriteLine( "My Dog name is " + this._name + ", Weight of my dog is : " + this._weight + " Kgs, Dog has tail : " + this._tail + " Dog has " + this._ears + " ears");
        }
    }
}
