namespace WebAppMVC1.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoruName { get; set; }
        public string desc { get; set; }
        public List<Car> сars { get; set; }
    }
}
