﻿namespace BasicCQRSMovies.Library.Models
{
    public class MovieModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }
    }
}
