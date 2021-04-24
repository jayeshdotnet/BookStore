using jk.BookStore.Models;
using jk.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jk.BookStore.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly BookRepository _bookRepository = null;
        
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        //public List<BookModel> GetAllBooks()
        public ViewResult GetAllBooks()
        {
            // define actions related to books , like get books, add books etc. (methods or action methods)
            //return _bookRepository.GetAllBooks();
            var data = _bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            // define actions related to books , like get books, add books etc. (methods or action methods)
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            // define actions related to books , like get books, add books etc. (methods or action methods)
            return _bookRepository.SearchBook(bookName, authorName);
        }

    }
}
