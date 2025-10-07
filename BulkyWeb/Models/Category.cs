using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]//Primary Key
        public int Id { get; set; }
        [Required]//Not null
        public string Name { get; set; }
        public int DispalyOrder { get; set; }
    }
}
