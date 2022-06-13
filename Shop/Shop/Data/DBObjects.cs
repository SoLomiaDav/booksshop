using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {    
             
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Book.Any())
            {
                content.AddRange(
                    new Book
                    {
                        name = "Дюна",
                        author = "Френк Герберт",
                        shortDesc = "с.656, Меланж, або прянощі, — найцінніша і найрідкісніша речовина у всесвіті, яка може все: від подовження життя до сприяння міжзоряним подорожам. І знайти її можна лише на одній планеті — непривітному пустельному Арракісі.",
                        img = "/img/dune.jpg",
                        price = 310,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Тверда обкладинка"] 
                    },
                    new Book
                    {
                        name = "Колір магії",
                        author = "Террі Пратчетт",
                        shortDesc = "с.310, Якого ж кольору ця магія, чи справді світ плаский, чи можна змінити свою долю і втекти від Смерті, якщо ти всього-на-всього фігурка у настільній грі, і ставки вже зроблено?",
                        img = "/img/magic.jpg",
                        price = 175,
                        isFavorite = false,
                        available = false,
                        Category = Categories["М'яка обкладинка"]
                    },
                    new Book
                    {
                        name = "Гобіт",
                        author = "Джон Р. Р. Толкін",
                        shortDesc = "с.384, Це історія надзвичайної пригоди, яку втнула ватага ґномів, узявшись відшукати загарбане драконом золото. Мимохіть учасником цієї ризикованої виправи став Більбо Торбин, прихильний до комфорту і позбавлений амбіцій гобіт, котрий, на власний подив, виявив неабияку винахідливість і вправність у ролі зломщика.",
                        img = "/img/hobbit.jpg",
                        price = 221,
                        isFavorite = true,
                        available = false,
                        Category = Categories["Тверда обкладинка"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Тверда обкладинка", desc = "Запобігає залому книги" },
                        new Category { categoryName = "М'яка обкладинка", desc = "Зручна для переносу" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);          
                                        
                }

                return category;
            }
        }
    }
}
