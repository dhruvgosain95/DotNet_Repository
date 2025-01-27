﻿using MVCLoginPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLoginPortal.ViewModel
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie == null)
                {
                    return "Add New Movie";
                }
                return "Edit Movie";
            }
        }
    }
}