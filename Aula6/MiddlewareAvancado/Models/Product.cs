using System.ComponentModel.DataAnnotations;

namespace MiddlewareAvancado.Models
{
    public class Product
    {
        [Required]
        public int Id {get; set;}
        [Required]
        public string Nome {get; set;}
        [Required]
        public decimal Preco {get; set;}
    }
}