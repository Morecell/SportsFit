using System.ComponentModel.DataAnnotations;

namespace SportsFit.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int Productname { get; set; }
    }
}
