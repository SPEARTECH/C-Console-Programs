using System;

namespace Book_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Branch branch = new Branch();
            
            Console.WriteLine("Available branches are: "+branch.getBranches() + "\n" );

            Library lib = new Library();

            Console.WriteLine("Please sign in with your username: ");

            string username = Console.ReadLine();


            while (true)
            {
                Console.WriteLine("What book do you want to look for? \n"
                    + createDB(lib));

                string selection = Console.ReadLine();

                Console.WriteLine(lib.getSelection(selection));

                Console.WriteLine("Would you like to check it out? (y/n)");

                string decision = Console.ReadLine();

                if (decision.ToLower().Equals("y"))
                {
                    Customer customer = new Customer(username, selection);
                    Console.WriteLine("Success! Here are all of your books.");
                    Console.Write(customer.getCustomerBooks(username));
                    break;
                }

            }
            Console.WriteLine("End of program.");
            Console.ReadLine();

        }
        public static string createDB(Library lib)
        {
            Book harrypotter = new Book("JK Rowling", "Harry Potter 1", "Childrens fantasy", "St. Louis");
            Book harrypotter2 = new Book("JK Rowling", "Harry Potter 2", "Childrens fantasy", "Vegas");
            Book harrypotter3 = new Book("JK Rowling", "Harry Potter 3", "Childrens fantasy", "NYC");

            lib.addBook(harrypotter);
            lib.addBook(harrypotter2);
            lib.addBook(harrypotter3);

            return harrypotter.title + "," + harrypotter2.title + "," + harrypotter3.title;
        }
    }
}
