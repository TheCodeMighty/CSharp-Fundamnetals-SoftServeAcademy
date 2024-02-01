using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Builder : IDeveloper
    {
        public string Tool { get; set; }

        public Builder() 
        {
            Tool = "hands";
        }

        public Builder(string tool)
        {
            Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Builder is creating something using {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder is destroying something using {Tool}");
        }

        public int CompareTo(IDeveloper developer)
        {
            return Tool.CompareTo(developer.Tool);
        }

        public override string ToString()
        {
            return $"Builder is using {Tool}";
        }
    }
}
