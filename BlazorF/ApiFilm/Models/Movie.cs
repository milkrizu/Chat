﻿namespace BlazorF.ApiFilm.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}
