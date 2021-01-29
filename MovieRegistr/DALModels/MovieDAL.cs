using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistr.DALModels
{
    public class MovieDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity(1, 1)
        public int MovieId { get; set; }
        public string Title { get; set; }

        public string Genre { get; set; }

        public double Runtime { get; set; }
    }
}
