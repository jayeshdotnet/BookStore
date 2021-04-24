using jk.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jk.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="J"},
                new BookModel(){Id=1, Title="MVC", Author="J"},
                new BookModel(){Id=1, Title="C#", Author="D"},
                new BookModel(){Id=1, Title="Java", Author="JK"},
                new BookModel(){Id=1, Title="Php", Author="JK"},
            };
        }
    }
}
