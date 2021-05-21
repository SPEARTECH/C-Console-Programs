using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Assignment
{
    class Library
    {
        List<Book> Catalog = new List<Book>();

        public void addBook(Book book)
        {
            Catalog.Add(book);
        }

        public void getBooks()
        {
            foreach (Book item in Catalog)
            {
                Console.WriteLine(item.title.ToString());
            }
        }

        public string getSelection(string selection)
        {
            string outputString = "";
            foreach (Book item in Catalog)
            {
                if (item.title.ToString() == selection){
                    outputString = selection + " is in the " + item.branch + " branch.";
                    break;
                }
            }

            return outputString;
        }

    }
}
