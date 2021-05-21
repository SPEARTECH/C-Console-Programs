using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Assignment
{
    class Book
    {
        public string author, title, genre, branch;

        public Book(string author, string title, string genre, string branch)
        {
            this.author = author;
            this.title = title;
            this.genre = genre;
            this.branch = branch;
        }
    }
}
