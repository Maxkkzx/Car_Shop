using MyShop.Data.Models;

namespace MyShop.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }

        Car getObjectCar(int carId);
    }
}
