using hemuppgift06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hemuppgift06
{
    public class Book
    {
        //properties
        public string Title { get; set; } = "untitled";
        public string Author { get; set; } = "unknown";
        public int Published { get; set; } = 0;

        //constructor
        public Book(string title, string author, int published)
        {
            Title = title;
            Author = author;
            Published = published;
        }

        public Book() { }
        public void GetBookInfo()
        {
            Console.WriteLine($"{Title}, {Author}, {Published}");
        }
    }
}