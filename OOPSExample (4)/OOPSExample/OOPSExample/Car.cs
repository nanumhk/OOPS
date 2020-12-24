using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    class Car
    {
        string _make;
        string _model;
        string _type;
        string _color;
        double _weight;
        int _year;
        int _wheels = 4;

        //Parameterless method
        /*public void SetCarDetails()
        {
            _make = "BMW";
            _model = "3 series";
            _type = "Sedan";
            _color = "Black";
            _weight = 1000.00;
            _year = 2019;

            Console.WriteLine("Make of Car is : {0}, Model of Car is : {1}, Type of Car is : {2}," +
                " Color of Car is : {3}, Weight of Car is : {4}, Year of manufacturing is : {5}",
                _make, _model, _type, _color, _weight, _year);
        }*/

        //Parameterized method
        public void SetCarDetails(string make, string model, string type, string color, double weight, int year)
        {
            _make = make;
            _model = model;
            _type = type;
            _color = color;
            _weight = weight;
            _year = year;

            Console.WriteLine("Make of Car is : {0}, Model of Car is : {1}, Type of Car is : {2}," +
                " Color of Car is : {3}, Weight of Car is : {4}, Year of manufacturing is : {5}",
                _make, _model, _type, _color, _weight, _year);
        }
    }
}
