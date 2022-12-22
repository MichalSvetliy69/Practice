using WebAppMVC1.Models;

namespace WebAppMVC1.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
