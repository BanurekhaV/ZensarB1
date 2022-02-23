using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstPrj
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Bookname { get; set; }
    }

    public class Publishers
    {
        [Key]
        public int PublisherId { get; set; }
        public string Publishername { get; set; }
    }

    public class BookContext :DbContext
    {
        public BookContext() : base("name=BookContext")
        {
          //  Database.SetInitializer<BookContext>(new CreateDatabaseIfNotExists<BookContext>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publishers> Publisher{ get;set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using(var db= new BookContext())
            {
                db.Books.Add(new Book { Bookname = "Introduction to EF" });
                db.SaveChanges();

                foreach(var book in db.Books)
                {
                    Console.WriteLine(book.Bookname);
                }
            }
            Console.Read();
        }
    }
}
