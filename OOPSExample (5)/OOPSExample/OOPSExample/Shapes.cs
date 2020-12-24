using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    //Parent Class to all Shapes
    //Generailezed data member and member funtions
    class Shapes
    {
        //Area is data member at parent class level
        //It is having access specifier as protected
        //All Child classes can access Area data member
        protected double _area;

        //If a class doesn't have a constructor
        //Then a default paremeterless constructor is present

        //Get Area is a memeber funtion
        //Get Area is a generalized form
        //It don't have any specific defination
        //No specific formula to calculate Area
        void GetArea()
        {   
            Console.WriteLine("Parent Class GetArea Method" + _area);
        }
    }
}
