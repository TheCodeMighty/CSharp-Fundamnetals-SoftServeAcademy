//#define Part1
//#define Part2

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if Part1
            Console.WriteLine("**********Task3**********");

            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer());
            developers.Add(new Programmer("C#", "VisualStudio"));
            developers.Add(new Programmer("JavaScript", "VisualStudioCode"));
            developers.Add(new Builder());
            developers.Add(new Builder("hammer"));
            developers.Add(new Builder("screwdriver"));

            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }

            Console.WriteLine("\n**********Task4**********");

            developers.Sort();

            foreach (var developer in developers)
            {
                Console.WriteLine(developer.ToString());
            }
#endif
#if Part2
            Console.WriteLine("\n**********Task5**********");

            Dictionary<uint, string> people = new Dictionary<uint, string>();

            Console.WriteLine("\n**********Task6**********");

            //Entering names of people from the consol
            Console.WriteLine("Enter IDs and names of 7 people");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Person#{i+1}\nEnter person's ID");

                //checking if the inout is of type uint
                if (!UInt32.TryParse(Console.ReadLine(), out uint id))
                {
                    do
                    {
                        Console.WriteLine("Input must be a positive int!");
                    } while (!UInt32.TryParse(Console.ReadLine(), out id));
                }
                //checking if the id is already in the dictionary
                if (people.ContainsKey(id))
                {
                    do
                    {
                        Console.WriteLine("There already exists id like that or input is not a positive int!");
                    } while (!UInt32.TryParse(Console.ReadLine(), out id) || people.ContainsKey(id));
                }

                Console.WriteLine("Enter person's name");
                string name = Console.ReadLine();

                //adding a new item to the dictionary
                people.Add(id, name);
            }

            Console.WriteLine("\n**********Task7**********");

            Console.WriteLine("To find a person enter their Id:");
            //checking if the inout is of type uint
            if (!UInt32.TryParse(Console.ReadLine(), out uint input))
            {
                do
                {
                    Console.WriteLine("Input must be a positive int!");
                } while (!UInt32.TryParse(Console.ReadLine(), out input));
            }

            //looking for the person with the input id in our dictionary
            if(people.TryGetValue(input, out string searchName))
            {
                Console.WriteLine($"Name of the person with id{input}: {searchName}");
            }
            else
            {
                Console.WriteLine("Id not found");
            }           
#endif
        }
    }
}
