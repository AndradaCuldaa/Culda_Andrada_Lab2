using System.ComponentModel.DataAnnotations;

namespace Culda_Andrada_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        public ICollection<Book>? Books { get; set; }
    }
}
