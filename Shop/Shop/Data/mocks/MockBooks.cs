using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory();

        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book {
                        name = "Дюна",
                        author = "Френк Герберт",
                        shortDesc = "656",
                        img = "/img/dune.jpg",
                        price = 350,
                        isFavorite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.First()
                    },
                    new Book {
                        name = "Дюна",
                        author = "Френк Герберт",
                        shortDesc = "656",
                        img = "/img/magic.jpg",
                        price = 350,
                        isFavorite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.First()
                    },
                    new Book {
                        name = "Дюна",
                        author = "Френк Герберт",
                        shortDesc = "656",
                        img = "/img/hobbit.jpg",
                        price = 350,
                        isFavorite = true,
                        available = false,
                        Category = _categoryBooks.AllCategories.First()
                    }

                };
            }
        }
        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
