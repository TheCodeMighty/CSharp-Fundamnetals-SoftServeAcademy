namespace Task4_Classes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Part1**********");

            Console.WriteLine("\n**********Part2**********\n");

            Car car1 = new Car();
            Car car2 = new Car("Supra", "red", 60000);
            Car car3 = new Car();

            car3.Input();

            car1.Print();
            car2.Print();
            car3.Print();

            Console.WriteLine("\n**********Part3**********\n");

            car2.ChangePrice(10);
            car2.Print();

            Console.WriteLine("\n**********Part4**********\n");

            Console.WriteLine("Enter new color of the car: ");
            car2.Color = Console.ReadLine().ToLower();
            car2.Print();

            Console.WriteLine("\n**********Part5**********\n");

            if (car1 == car2)
            {
                Console.WriteLine("Cars are the same");
            }
            else
            {
                Console.WriteLine("Cars are not the same");
            }

            if(car2 != car3)
            {
                Console.WriteLine("Cars are not the same");
            }
            else
            {
                Console.WriteLine("Cars are the same");
            }

            Console.WriteLine("\n**********Part6**********\n");

            car3.ToString();
        }
    }
}
