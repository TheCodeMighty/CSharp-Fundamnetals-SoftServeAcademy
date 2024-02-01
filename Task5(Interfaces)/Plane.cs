using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Interfaces_
{
    public class Plane: IFlyable
    {
        public string mark { get; set; }
        public bool flyHigh { get; set; }

        public Plane()
        {
            mark = "Plane";
            flyHigh = false;
        }

        public Plane(string mark, bool flyHigh)
        {
            this.mark = mark;
            this.flyHigh = flyHigh;
        }

        public void Fly()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Plane mark: {mark}. {(flyHigh? "can fly high" : "cannot fly high")}";
        }
    }
}
