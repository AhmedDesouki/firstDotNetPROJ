using System.ComponentModel.DataAnnotations;

namespace firstDotNetPROJ.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
