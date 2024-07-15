using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int BookID { get; set; }

        public Book(string title, string author, int bookID)
        {
            Title = title;
            Author = author;
            BookID = bookID;
        }

        public abstract void DisplayInfo();
    }

    // FictionBook Class
    class FictionBook : Book
    {
        public string Genre { get; set; }

        public FictionBook(string title, string author, int bookID, string genre)
            : base(title, author, bookID)
        {
            Genre = genre;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Fiction Book - ID: {BookID}, Title: {Title}, Author: {Author}, Genre: {Genre}");
        }
    }

    // NonFictionBook Class
    class NonFictionBook : Book
    {
        public string Subject { get; set; }

        public NonFictionBook(string title, string author, int bookID, string subject)
            : base(title, author, bookID)
        {
            Subject = subject;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Non-Fiction Book - ID: {BookID}, Title: {Title}, Author: {Author}, Subject: {Subject}");
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
            Console.WriteLine($"{name} is the name of the person with {personID} who is {age} years old");
        }
    }

    class Librarian : Person
    {
        public int Employee_ID;
        public Librarian(string name, int age, int personID, int id) : base(name, age, personID)
        {
            Employee_ID = id;
        }

        public void Issuebook(Book book, Person user)
        {
            Console.WriteLine($"{book.Title} is issued to {user.name}");
        }

        public void Returnbook(Book book, Person user)
        {
            Console.WriteLine($"{book.Title} is returned by {user.name}");
        }
    }

    class Library
    {
        public string Library_name;
        public int Library_ID;
        private List<Book> books;
        private Librarian librarian;

        public Library(string library_name, int library_ID)
        {
            Library_name = library_name;
            Library_ID = library_ID;
            books = new List<Book>();
        }

        public void Addbook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} by {book.Author} added to the library.");
        }

        public void Viewbook()
        {
            Console.WriteLine($"books in {Library_name}");
            foreach (var book_display in books)
            {
                book_display.DisplayInfo();
            }
        }

        public void Removebook(int bookID)
        {
            Book bookToRemove = books.Find(b => b.BookID == bookID);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"{bookToRemove.Title} removed from the library");
            }
            else
            {
                Console.WriteLine($"Book with ID {bookID} not found in library");
            }
        }

        public void ListIssuedBooks(string title, string name, int personId, int Employee_ID)
        {
            Console.WriteLine($"{title} is issued to {name} with PersonID {personId} by the employee {Employee_ID}");
        }

        public void SearchBooks(string title)
        {
            Book booktosearch = books.Find(b => b.Title == title);
            if (booktosearch != null)
            {
                Console.WriteLine($"{title} is in the library");
            }
            else
            {
                Console.WriteLine($"{title} is not in the library");
            }
        }

        public void IssueFine(string name)
        {
            Console.WriteLine($"The librarian {name} issued a fine for losing a book");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FictionBook book1 = new FictionBook("Great Expectations", "Charles Dickens", 2255, "Fictional Autobiography");
            NonFictionBook book2 = new NonFictionBook("Jane Eyre", "Charlotte Bronte", 7777, "Romance");

            Person p1 = new Person("Zahra", 18, 4422);

            Library L1 = new Library("National library", 9301);
            L1.Addbook(book1);
            L1.Addbook(book2);
            Librarian employee1 = new Librarian("Aliha", 25, 321, 321);

            while (true)
            {
                Console.WriteLine("\nLibrary Management System:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. View Books");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. Issue Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. List Issued Books");
                Console.WriteLine("8. Issue Fine");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter book author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter book ID: ");
                        int bookID = int.Parse(Console.ReadLine());
                        Console.Write("Enter book type (1 for Fiction, 2 for Non-Fiction): ");
                        int type = int.Parse(Console.ReadLine());

                        if (type == 1)
                        {
                            Console.Write("Enter genre: ");
                            string genre = Console.ReadLine();
                            L1.Addbook(new FictionBook(title, author, bookID, genre));
                        }
                        else if (type == 2)
                        {
                            Console.Write("Enter subject: ");
                            string subject = Console.ReadLine();
                            L1.Addbook(new NonFictionBook(title, author, bookID, subject));
                        }
                        else
                        {
                            Console.WriteLine("Invalid book type.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter book ID to remove: ");
                        int removeBookID = int.Parse(Console.ReadLine());
                        L1.Removebook(removeBookID);
                        break;

                    case "3":
                        L1.Viewbook();
                        break;

                    case "4":
                        Console.Write("Enter book title to search: ");
                        string searchTitle = Console.ReadLine();
                        L1.SearchBooks(searchTitle);

                        break;
                    case "5":
                        employee1.Issuebook(book1, p1);
                        break;

                    case "6":
                        employee1.Returnbook(book1, p1);
                        break;

                    case "7":
                        L1.ListIssuedBooks(book2.Title, p1.name, 4422, 321);
                        break;

                    case "8":
                        L1.IssueFine(employee1.name);
                        break;

                    case "9":
                        Console.WriteLine("Exiting the system.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}