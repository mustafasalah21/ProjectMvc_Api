using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [NotMapped]
        public IFormFile clinetfile { get; set; }
        public ICollection<Item>? Items { get; set; }
        public byte[]? dbimge { get; set; }
        [NotMapped]
        public string? imge64
        {
            get
            {
                if (dbimge != null)
                {
                    string imgbase64data = Convert.ToBase64String(dbimge,0,dbimge.Length);
                    return "data:imeges/jpg;base64,"+ imgbase64data;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

    }
}
