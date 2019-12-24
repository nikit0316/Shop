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

            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla Model S",
                         shortDesc = "Быстрый автомобиль",
                         longDesc = "Матушка природа будет тобой довольна",
                         img = "/img/model s.jpg",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Электромобили"]
                     },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/m3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Renault Kaptur",
                        shortDesc = "Элегантный кроссовер",
                        longDesc = "Моя страна. Мой стиль. Мой Renault.",
                        img = "/img/kaptur.jpg",
                        price = 20000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Qashaqai",
                        shortDesc = "Твой город. Твой ход.",
                        longDesc = "Будущее наступило. Ход за тобой.",
                        img = "/img/qas.jpg",
                        price = 24000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
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
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryname = "Электромобили", desc = "Современный вид транспорта"},
                        new Category {categoryname = "Классические автомобили", desc ="Машины с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryname, el);
                }

                return category;
            }
        }
    }
}
