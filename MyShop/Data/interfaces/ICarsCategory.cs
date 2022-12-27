using MyShop.Data.Models;

namespace MyShop.Data.interfaces
{
    public interface ICarsCategory
    {

        IEnumerable<Category> AllCategories { get; }
    }
}
