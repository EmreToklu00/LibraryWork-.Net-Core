using System;
using System.ComponentModel.DataAnnotations;

namespace librarywork.src.models
{
    public class Author
    {
        public Author() { }


        [Required(ErrorMessage = "ID is required.")]
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Name cannot exceed 15 characters.")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Surname is required.")]
        [MaxLength(15, ErrorMessage = "Surname cannot exceed 15 characters.")]
        public String Surname { get; set; }


    }
}

