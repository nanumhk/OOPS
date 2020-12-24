using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    //RightAngleTraingleShape is a Child class of TriangleShape
    //TriangleShape is a parent class to RightAngleTraingleShape Child class
    //Ultimate parent class to RightAngleTraingleShape is Shapes class
    //As TriangleShape class is inherited from Shapes class
    //Multi level inheritance
    class RightAngleTraingleShape : TriangleShape
    {
        //Specific data memebers for RightAngleTraingleShape 
        private double _hypotenuse;
        private double _side1;
        private double _side2;

        //If Parent class has parameterized constructor then it is mandatory to call the parent class parameterized constructor
        //base is a keyword by which we can call parent class constructor
        public RightAngleTraingleShape() : base(4, 6)
        { }

        //Parameterized Constructor
        public RightAngleTraingleShape(double side1, double side2):base(4, 6)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        public void GetArea()
        {
            this._area = (this._side1 * this._side2) / 2;
            Console.WriteLine("Area of right angle triangle is : " + this._area);
        }

        public void GetHypotenuseSide()
        {
            //local variable
            double formula = ((_side1 * _side1) + (_side2 * _side2));
            double actualSqrt = Math.Sqrt(formula);
            this._hypotenuse = actualSqrt;
            Console.WriteLine("Hypotenuse of right angle trianlge is : " + this._hypotenuse);
        }
    }
}
