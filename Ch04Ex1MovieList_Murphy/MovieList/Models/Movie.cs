using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieList.Models
{
    public class Movie
    {
        // EF Core will configure the database to generate this value
        public int MovieId { get; set; } //getters and setters

        [Required(ErrorMessage = "Please enter a name.")] //data validation attributes
            //instead of using a ? to make a reference nullable we assign its value to empty this reduces bugs
        public string Name { get; set; } = string.Empty;//reference

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
            //? is used when using the Required attriute bc the data type must be nullable
        public int? Year { get; set; } //value type

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; } //value type

        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; } = string.Empty;

        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();

    }
}
