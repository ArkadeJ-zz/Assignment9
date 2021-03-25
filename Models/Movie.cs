using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment9.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(1888, 2021, ErrorMessage = "Must be between 1888 and 2021")]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [StringLength(25, ErrorMessage = "Note cannot be more than 25 characters")]
        public string Notes { get; set; }
    }
}
