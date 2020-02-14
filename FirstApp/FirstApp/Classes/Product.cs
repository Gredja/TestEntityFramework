using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        // навигационное свойство
        public Company Manufacturer { get; set; }
    }
}
