using Lakshman.BookStore.Models;
using Lakshman.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lakshman.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookrepository=null;

        public BookController()
        {
            bookrepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data= bookrepository.GetAllBooks();
            return View();
        }

        public ViewResult GetBook(int id)
        {
            var data1= bookrepository.GetBookById(id);
            return View();
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return bookrepository.SearchBook(bookName,authorName);
        }
    }
}
