﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistr.Services
{
   public interface IMovies
    {
        public List<Movie> MovieList { get; }
    }
}
