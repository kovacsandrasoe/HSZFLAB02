namespace HSZFLAB02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1: Add Movie");
            Console.WriteLine("2: List Movies");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {
                Add();
            }
            else if (choice == "2")
            {
                List();
            }
        }

        static void List()
        {
            Console.Clear();
            Console.WriteLine("LIST MENU");
            Console.ReadLine();
            Menu();
        }

        static void Add()
        {
            Console.Clear();
            Console.WriteLine("ADD MENU");
            Console.ReadLine();
            Menu();
        }
    }
}
