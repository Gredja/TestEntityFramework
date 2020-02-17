using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp.Classes
{
    [Table("People")]
    public partial class User
    {
        public int Id { get; set; }
        [Column("UserName")]
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
    }
}
