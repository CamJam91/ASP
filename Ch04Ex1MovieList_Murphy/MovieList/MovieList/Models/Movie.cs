using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Movie
    {
            //this (because of ID) is the primary key in our database table
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Please enter a name.")] //required keyword enforces non null value
            //even though references can be nullable like values with ? it is safer to assign an empty string
        public string name { get; set; } = string.Empty; //reference type (pointer)

            //value types in C# are usualy non nullable but the requires must work with a nullable value
            //so ? is used to make the values nullable
        [Required(ErrorMessage = "Please enter a year")]
        [Range(1889,2999, ErrorMessage = "Year must be after 1889.")] //range for rquired to enforce
        public int? Year { get; set; } //value type

        [Required(ErrorMessage = "Please enter a rating")]
        [Range(1,5, ErrorMessage = "Rating must be between 1 and 5")]
        public int? Rating { get; set; } //value type
    }
}
