namespace Homework4_Classes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Part1***********");
            Person[] people =
            {
                new Person("Arsenii", new DateTime(2005, 5, 18)),
                new Person(),
                new Person("John", new DateTime(2100, 4, 8)),
                new Person("Mike", new DateTime(2020, 1, 25)),
                new Person("Ronald", new DateTime(1998, 8, 30)),
                new Person()
            };

            people[5].Input();

            foreach (var person in people)
            {
                person.Ouput();
            }

            Console.WriteLine("\n*********Part2***********");

            foreach (var person in people)
            {
                Console.WriteLine(person.Age());
            }

            Console.WriteLine("\n*********Part3***********");

            foreach (var person in people)
            {
                if(person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
            }

            Console.WriteLine("\n*********Part4***********");

            foreach (var person in people)
            {
                person.Ouput();
            }

            Console.WriteLine("\n*********Part5***********");

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Person{i} and Person{j} have the same name({people[i].Name}).");
                    }
                }
            }
        }
    }
}
