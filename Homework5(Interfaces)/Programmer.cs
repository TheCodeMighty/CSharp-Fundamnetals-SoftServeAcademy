using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Programmer : IDeveloper
    {
        public string language { get; set; }
        public string Tool { get; set; }

        public Programmer()
        {
            language = "Assembly";
            Tool = "RunCode";
        }

        public Programmer(string language, string tool)
        {
            this.language = language;
            Tool = tool;
        }
        public void Create()
        {
            Console.WriteLine($"Programmer is creating a program in {Tool} using {language} language");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer is destroying a program in {Tool} using {language} language");
        }

        public int CompareTo(IDeveloper developer)
        {
            return Tool.CompareTo(developer.Tool);
        }

        public override string ToString()
        {
            return $"Programmer is using {Tool} and knows {language} lanhuage";
        }
    }
}
