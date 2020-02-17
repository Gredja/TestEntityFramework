namespace FirstApp.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Rate { get; set; }
        // навигационное свойство
        public Company Manufacturer { get; set; }
    }
}
