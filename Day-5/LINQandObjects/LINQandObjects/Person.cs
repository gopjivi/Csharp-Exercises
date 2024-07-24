using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandObjects
{
    public class Person
    {
        // Property for Name
        public string Name { get; set; }

        // Property for Gender
        public string Gender { get; set; }

        // Property for Age
        public int Age { get; set; }

        // Property for Hometown
        public string Hometown { get; set; }
        public Person(string name, string gender, int age, string hometown)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Hometown = hometown;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Hometown: {Hometown}");
            Console.WriteLine();
        }
    }
}
