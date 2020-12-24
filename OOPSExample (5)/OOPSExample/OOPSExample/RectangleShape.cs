using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    //RectangleShape is a Child class of Shapes
    //Shapes is a parent class to RectanlgeShape Child class
    class RectangleShape : Shapes
    {
        //Specific data memebers for RectangleShape
        private double _length;
        private double _width;

        //Parameterized constructor which initialize the length and weidth data memebers of RectangleShape class
        //length and width are formal parameters to the constructor
        public RectangleShape(double length, double width)
        {
            //This is a keyword which is used to access data member of class
            //_length data member is initialized with value of length parameter
            this._length = length;
            //_width data member is initialized with value of width parameter
            this._width = width;
        }

        //Get Area is a Specialized member funtion which has specific formula to calculate area of rectangle
        public void GetArea()
        {
            //This is a keyword by which we are using data member of parent class
            //this._area is present at parent level and access at child class level
            //It's posible as _area is having protected access specifier
            this._area = _length * _width;
            Console.WriteLine("Area of Rectangle is : " + this._area);
        }
    }
}
