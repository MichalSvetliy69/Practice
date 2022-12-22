using WebAppMVC1.Models;

namespace WebAppMVC1.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car getObjectCar(int carId);
        
    }
}
