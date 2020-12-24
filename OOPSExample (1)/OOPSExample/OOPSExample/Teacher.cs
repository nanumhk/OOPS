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

        public void GetSkillSetDetails()
        {
            foreach (var skill in this._skillSet)
            {
                switch (skill)
                {
                    case "C#":
                        Console.WriteLine("C# is a Scripting language");
                        break;
                    case "Java":
                        Console.WriteLine("Java is a Scripting language");
                        break;
                    case "VB.Net":
                        Console.WriteLine("VB.Net is outdated skill");
                        break;
                    case "Python":
                        Console.WriteLine("Python is a trending skill");
                        break;
                    default:
                        Console.WriteLine("Skill is out context");
                        break;
                }
            }
        }
    }
}
