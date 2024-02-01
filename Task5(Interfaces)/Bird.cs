using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Interfaces_
{
    public class Bird : IFlyable
    {
        public string name { get; set; }
        public bool canFly { get; set; }

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
        
        public Bird()
        {
            name = "Bird";
            canFly = false;
        }

        public void Fly()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() 
        {
            return $"Bird name: {name}. {(canFly? "can fly" : "cannot fly")}";
        }
    }
}
