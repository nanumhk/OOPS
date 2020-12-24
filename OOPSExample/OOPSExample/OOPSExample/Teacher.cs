using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSExample
{
    class Teacher : Person
    {
        private string[] _skillSet;

        public Teacher(string[] skillSet, string name, int age):base(name, age)
        {
            this._skillSet = skillSet;
        }
    }
}
