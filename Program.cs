using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new instance of Book class and hold properties of book ISBN, author, title, publisher, and copyright date 
            Book book1 = new Book();
            book1.ISBN = "123";
            book1.author = "A,B";
            book1.title = "book1";
            book1.publisher = "pub1";
            book1.copyrightDate = "1/1/1";

            Book book2 = new Book();
            book2.ISBN = "456";
            book2.author = "C,D";
            book2.title = "book2";
            book2.publisher = "pub2";
            book2.copyrightDate = "2/2/2";

            Book book3 = new Book();
            book3.ISBN = "789";
            book3.author = "E,F";
            book3.title = "book3";
            book3.publisher = "pub3";
            book3.copyrightDate = "3/3/3";

            Book book4 = new Book();
            book4.ISBN = "101112";
            book4.author = "G,H";
            book4.title = "book4";
            book4.publisher = "pub4";
            book4.copyrightDate = "4/4/4";

            Book book5 = new Book();
            book5.ISBN = "1131415";
            book5.author = "I,J";
            book5.title = "book5";
            book5.publisher = "pub5";
            book5.copyrightDate = "5/5/5";



            //create List for book ISBN, author, title, publisher, and copyright date 
            List<Book> myBookList = new List<Book>();
            myBookList.Add(book1);
            myBookList.Add(book2);
            myBookList.Add(book3);
            myBookList.Add(book4);
            myBookList.Add(book5);


            //foreach loop to display books in book list
            foreach (Book book in myBookList)
            {
                Console.WriteLine(book.ISBN);
                Console.WriteLine(book.author);
                Console.WriteLine(book.title);
                Console.WriteLine(book.publisher);
                Console.WriteLine(book.copyrightDate);

            }//end foreach loop




            //create Dictionary for book ISBN, author, title, publisher, and copyright date 
            Dictionary<string, Book> myDictionary = new Dictionary<string, Book>();
            myDictionary.Add(book1.ISBN, book1);
            myDictionary.Add(book2.ISBN, book2);
            myDictionary.Add(book3.ISBN, book3);
            myDictionary.Add(book4.ISBN, book4);
            myDictionary.Add(book5.ISBN, book5);


            //foreach loop to display books in dictionary
            foreach (Book book in myDictionary.Values)
            {
                Console.WriteLine("Author is {0} Title is {1} Publisher is {2} Copyright Date is {3}",
                     book.author, book.title, book.publisher, book.copyrightDate);
                Console.WriteLine();
            }



            //pause program 
            Console.ReadLine();
        }//end main




    }//end class


    class Book
    {
        public string ISBN { get; set; }

        public string author { get; set; }

        public string title { get; set; }

        public string publisher { get; set; }

        public string copyrightDate { get; set; }
    }




}//end namespace
