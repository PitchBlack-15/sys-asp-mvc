﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspmvc.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }  
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public byte GenreId { get; set; }
    }
    
}