﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string TmdbUrl { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Tagline { get; set; }
        public int Runtime { get; set; }
        public decimal Budget { get; set; }
        public decimal Revenue { get; set; }
        public string BackdropUrl { get; set; }
        public string PosterUrl { get; set; }
        public string ImdbUrl { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; } = [];
        public ICollection<MovieCast> MovieCasts { get; set; } = [];
        public ICollection<Trailer> Trailers { get; set; } = [];
        public ICollection<Purchase> Purchases { get; set;} = [];
    }
}
