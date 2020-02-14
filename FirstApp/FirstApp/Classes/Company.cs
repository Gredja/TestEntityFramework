using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp.Classes
{
    [NotMapped]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
