using System.ComponentModel.DataAnnotations;

namespace librarywork.src.models
{
    public class Book
    {

        public Book() { }
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Name cannot exceed 15 characters.")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Publish Year is required.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Publish Year must be a four-digit number.")]
        public String PublishYear { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(10, ErrorMessage = "Title cannot exceed 10 characters.")]

        public String Title { get; set; }

        [Required(ErrorMessage = "Author ID is required.")]
        public int AuthorId { get; set; }


    }
}

