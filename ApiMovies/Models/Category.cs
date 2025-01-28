using System.ComponentModel.DataAnnotations;

namespace ApiMovies.Models
{
    public class Category
    {
        //Ovde se dodavaat svojstvata
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
