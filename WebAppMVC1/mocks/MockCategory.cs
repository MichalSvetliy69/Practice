using WebAppMVC1.interfaces;
using WebAppMVC1.Models;

namespace WebAppMVC1.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoruName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {categoruName = "Классические автомобили", desc = "Машины с двигателем внутриннего сгорания"},
                };
            }
        }
    }
}
