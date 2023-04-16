namespace Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlueRayCollection brc = new BlueRayCollection();
            while (true)
            {
                Console.WriteLine("0. Quit\r\n1. Add BlueRay to collection\r\n2. See collection");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        default:
                            throw new FormatException();
                        case 0:
                            System.Environment.Exit(0);
                            break;
                        case 1:
                            Console.WriteLine("What is the title?");
                            string title = Console.ReadLine();
                            Console.WriteLine("Who is the director?");
                            string director = Console.ReadLine();
                            Console.WriteLine("What was the year of release?");
                            int year = int.Parse(Console.ReadLine());
                            Console.WriteLine("What was the cost?");
                            double cost = double.Parse(Console.ReadLine());
                            brc.add(title, director, year, cost);
                            break;
                        case 2:
                            brc.show_all();
                            break;
                    }
                }
                catch (FormatException e) { Console.WriteLine(e.Message.ToString()); }
                Console.WriteLine();
            }
        }
    }
}