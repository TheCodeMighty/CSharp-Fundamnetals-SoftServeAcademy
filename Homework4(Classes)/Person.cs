using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Classes_
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "Noname";
            birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            if (DateTime.Now.Year < birthYear.Year)
            {
                return -1;
            }
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the year of birth: ");

            int _birthYear;
            if(Int32.TryParse(Console.ReadLine(), out _birthYear))
            {
                birthYear = new DateTime(_birthYear, 1, 1);
            }
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Name: {name}\nYear of birth: {birthYear.Year}";
        }

        public void Ouput()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Name == person2.Name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return person1.Name != person2.Name;
        }
    }
}
