using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Classes_
{
    class Car
    {
        public string name;
        public string color { get; set; }

        public double price;

        public const string companyName = "Toyota";

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {
            name = "car";
            color = "white";
            price = 10000;
        }

        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void Input()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Color: ");
            color = Console.ReadLine().ToLower();
            Console.WriteLine("Price: ");
            Double.TryParse(Console.ReadLine(), out price);
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}\nColor: {color}\nPrice: {price}$");
        }

        public void ChangePrice(double x)
        {
            price -= price * (x / 100);
        }

        public static bool operator ==(Car car1, Car car2)
        {
            return car1.price == car2.price && car1.name == car2.name;
        }

        public static bool operator !=(Car car1, Car car2) 
        {
            return car1.price != car2.price && car1.name != car2.name; 
        }

        public override string ToString()
        {
            return $"Name: {name}\nColor: {color}\nPrice: {price}$";
        }
    }
}
