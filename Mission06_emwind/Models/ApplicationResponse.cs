using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission06_emwind.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage ="Notes must be 25 characters or less")]
        public string Notes{ get; set; }
    }
}
