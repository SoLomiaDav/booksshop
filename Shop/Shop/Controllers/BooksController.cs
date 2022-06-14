using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBooksCategory iBooksCat)
        {
            _allBooks = iAllBooks;
            _allCategories = iBooksCat;
        }

        [Route("Books/List")]
        [Route("Books/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                books = _allBooks.Books.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("soft", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("М'яка обкладинка")).OrderBy(i => i.id);
                    currCategory = "М'яка обкладинка";
                }
                else if (string.Equals("hard", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Тверда обкладинка")).OrderBy(i => i.id);
                    currCategory = "Тверда обкладинка";
                }

                             
            }

            var bookObj = new BooksListViewModel
            {
                allBooks = books,
                currCategory = currCategory
            };

            ViewBag.Title = "SomiBook";
            

            return View(bookObj);
        }
    }
}
