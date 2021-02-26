using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LibraryMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Book title is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Author for the book is required")]
        public string Author { get; set; }
        [StringLength(9)]
        public string ISBN { get; set; }
         
        public Book()
        {


        }
    }
}
