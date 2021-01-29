﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistr.Models.MovieRegistration
{
    public class AddMovieFormViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public int Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }

        public double Runtime { get; set; }
    }
}
