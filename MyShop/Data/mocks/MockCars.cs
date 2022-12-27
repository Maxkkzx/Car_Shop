using MyShop.Data.interfaces;
using MyShop.Data.Models;
using System.Transactions;

namespace MyShop.Data.mocks
{
    public class MockCars : IAllCars
    {
        
        private readonly ICarsCategory _categoryCras = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla Model S", 
                        ShortDesc = "Быстрый автомобиль", 
                        LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla", 
                        Img = "https://americamotorsby.ams3.digitaloceanspaces.com/1328/1.jpg", 
                        Price = 45000, 
                        IsFavourite= true,
                        available = true, 
                        Category = _categoryCras.AllCategories.First()
                    },

                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://avatars.mds.yandex.net/get-verba/997355/2a0000017c0cbc4e6038525520003c7e7136/cattouchret",
                        Price = 11000,
                        IsFavourite= false,
                        available = true,
                        Category = _categoryCras.AllCategories.Last()
                    },

                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://avatars.mds.yandex.net/get-verba/1540742/2a00000178874741ebe297e8ba6c4145a1c7/cattouchret",
                        Price = 65000,
                        IsFavourite= true,
                        available = true,
                        Category = _categoryCras.AllCategories.Last()
                    },

                    new Car
                    {
                        Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://avatars.mds.yandex.net/get-verba/937147/2a0000017fadb80e8a8c437a0b9cc56075aa/cattouchret",
                        Price = 40000,
                        IsFavourite= false,
                        available = false,
                        Category = _categoryCras.AllCategories.Last()
                    },

                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "https://s.auto.drom.ru/i24213/c/photos/fullsize/nissan/leaf/nissan_leaf_754286.jpg",
                        Price = 40000,
                        IsFavourite= true,
                        available = true,
                        Category = _categoryCras.AllCategories.First()
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
