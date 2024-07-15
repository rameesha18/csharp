using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8
{
    class Book
    {
        public string title;
        public string author;
        public int bookID;

        public Book(string Title, string Author, int BookID)
        {
            title = Title;
            author = Author;
            bookID = BookID;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"This book is {title} written by {author} with {bookID} bookID");
        }
    }


    class Person
    {
        public string name;
        public int age;
        public int personID;


        public Person(string Name, int Age, int PersonID)
        {
            name = Name;
            age = Age;
            personID = PersonID;
        }

        public void display()
        {
            Console.WriteLine($"{name} is the name of the peron with {personID} who is {age} years old");

        }
    }
  
    class Library
    {
        public string Library_name;
        public int Library_ID;
        private List<Book> books;


        public Library(string library_name, int library_ID)
        {
            Library_name = library_name;
            Library_ID = library_ID;
            books = new List<Book>();
        }
        public void Addbook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.title} by {book.author} added to the library.");
        }
        public void Viewbook()
        {
            Console.WriteLine($"books in {Library_name}");
            foreach (var book_display in books)
            {
                book_display.DisplayInfo();
            }
        }

        public void Removebook(int BookID)
        {
            Book bookToRemove = books.Find(b => b.bookID == BookID);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"{bookToRemove.title} removed from the library");
            }
            else
            {
                Console.WriteLine($"Book with ID {BookID} not found in library");
            }
        }
        public void ListIssuedBooks(string title, string name, int personId, int Employee_ID)
        {
            Console.WriteLine($"{title} is issued to {name} with PersonID {personId} by the employee {Employee_ID}");
        }
        public void SearchBooks(string Title)
        {
            Book booktosearch = books.Find(b => b.title == Title);
            if (booktosearch != null)
            {
                Console.WriteLine($"{Title} is in the library");
            }
            else
            {
                Console.WriteLine($"{Title} is not in the library");
            }
        }
      


    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Great Expectations", "Charles Dickens", 2255);
            Book book2 = new Book("Jane Eyre", "Charlotte Bronte", 7777);



            book1.DisplayInfo();
            book2.DisplayInfo();

            Person p1 = new Person("Zahra", 18, 4422);

            p1.display();

            Library L1 = new Library("National library", 9301);



            L1.Addbook(book1);
            L1.Addbook(book2);

            L1.Viewbook();

            L1.Removebook(7777);
            L1.Removebook(7707);

            L1.ListIssuedBooks(book2.title, p1.name, 4422, 321);

            L1.SearchBooks(book1.title);
            
        }
    }
}