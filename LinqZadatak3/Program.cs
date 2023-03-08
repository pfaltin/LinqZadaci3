namespace LinqZadatak3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("exetr 3 LINQ!");
            Console.WriteLine("\n\nKoliko brojeva treba unijeti");
            int amountOfNumbers = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.WriteLine("unesi broj");
                numbers.Add(int.Parse(Console.ReadLine()));

            }

            int position = 1;
            Console.WriteLine("\n\nUneseni brojevi");
            foreach (int i in numbers)
            {
                Console.WriteLine("uneseni broj na poziciji {1} je {0} ", i, position);
                position++;
            }


            Console.WriteLine("\n\n Unesi broj za granicu");
            int limitNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\n limit je " + limitNumber);
            Console.WriteLine("\n\n idu veci brojevi");

            IEnumerable<int> bigerNums = numbers
                                                .Where(e => e > limitNumber)
                                                .Select(e => e)
                                                .ToList();

            foreach (int i in bigerNums)
            {
                Console.WriteLine("veci broj je {0}", i);
            }

        }
    }
}