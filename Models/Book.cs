using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LibraryMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = "Book title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author/s for the book is required")]
=======
        [Required]
        public string Name { get; set; }
>>>>>>> parent of 30d21e7 (Add authorization adn authentication)
        public string Author { get; set; }
        public string ISBN { get; set; }
         
        public Book()
        {


        }
    }
}
