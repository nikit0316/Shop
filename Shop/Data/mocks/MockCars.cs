using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name ="Tesla Model S",
                        shortDesc="Быстрый автомобиль",
                        longDesc="Матушка природа будет тобой довольна",
                        img="/img/model s.jpg",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category= _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name="BMW M3",
                        shortDesc="Дерзкий и стильный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/m3.jpg",
                        price=65000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Renault Kaptur",
                        shortDesc="Элегантный кроссовер",
                        longDesc="Моя страна. Мой стиль. Мой Renault.",
                        img="/img/kaptur.jpg",
                        price=20000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Nissan Qashaqai",
                        shortDesc="Твой город. Твой ход.",
                        longDesc="Будущее наступило. Ход за тобой.",
                        img="/img/qas.jpg",
                        price=24000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
