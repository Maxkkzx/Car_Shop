using MyShop.Data.interfaces;
using MyShop.Data.Models;

namespace MyShop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", Desc = "Современный вид транспорта",},
                    new Category {categoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего згорания" }
                };
            }
        }
    }
}
