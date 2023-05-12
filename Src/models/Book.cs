using System;
using System.ComponentModel.DataAnnotations;

namespace librarywork.src.models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public String Name { get; set; }

        public String PublishYear { get; set; }

        public String Title { get; set; }

        [Required]
        public int AuthorId { get; set; }


    }
}

