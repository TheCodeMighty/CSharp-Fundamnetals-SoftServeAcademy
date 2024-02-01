namespace Task5_Interfaces_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Part3**********");

            List<IFlyable> objects = new List<IFlyable>();
            objects.Add(new Bird());
            objects.Add(new Bird("Eagle", true));
            objects.Add(new Plane());
            objects.Add(new Plane("F-16", true));

            foreach (var obj in objects)
            {
                obj.Fly();
            }


            Console.WriteLine("**********Part4**********");

            List<int> collection = new List<int>();
            Console.WriteLine("Enter 10 ints");

            for(int i = 0; i < 10; i++)
            {
                if(!Int32.TryParse(Console.ReadLine(), out int input))
                {
                    do
                    {
                        Console.WriteLine("Input must be of type int!");
                    } while (!Int32.TryParse(Console.ReadLine(), out input));
                }
                collection.Add(input);
            }

            Console.WriteLine("**********Part4.1**********");
            Console.WriteLine("Positions of element -10");
            for (int i = 0; i < 10; i++)
            {
                if (collection[i] == -10)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("**********Part4.2**********");

            for (int i = collection.Count -1 ; i >= 0; i--)
            {
                if (collection[i] > 20)
                {
                    collection.RemoveAt(i);
                }
            }

            Console.Write("New collection: ");
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("**********Part4.3**********");

            collection.Insert(2, 1);
            collection.Insert(8, -3);
            collection.Insert(5, -4);

            Console.Write("New collection: ");
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("**********Part4.4**********");
            collection.Sort();

            Console.Write("New collection: ");
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
