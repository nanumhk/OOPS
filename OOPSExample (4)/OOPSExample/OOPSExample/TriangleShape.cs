using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    //TriangleShape is a Child class of Shapes
    //Shapes is a parent class to TriangleShape Child class
    class TriangleShape : Shapes
    {
        //Specific data memebers for TraingleShape
        private double _base;
        private double _side2;
        private double _side3;
        private double _height;

        //Parameterized constructor which initialize the base and height data memebers of TriangleShape class
        //abc and pqr are formal parameters to the constructor
        public TriangleShape(double abc, double pqr)
        {
            //This is a keyword which is used to access data member of class
            //_base data member is initialized with value of abc parameter
            this._base = abc;
            //_height data member is initialized with value of pqr parameter
            this._height = pqr;
        }

        //Get Area is a Specialized member funtion which has specific formula to calculate area of traingle
        public void GetArea()
        {
            //This is a keyword by which we are using data member of parent class
            //this._area is present at parent level and access at child class level
            //It's posible as _area is having protected access specifier
            this._area = (_base * _height) / 2;
            Console.WriteLine("Area of triangle is : " + this._area);
        }
    }
}
