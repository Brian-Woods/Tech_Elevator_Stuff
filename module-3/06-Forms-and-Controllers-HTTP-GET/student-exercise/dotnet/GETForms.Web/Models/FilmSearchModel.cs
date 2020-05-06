using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace GETForms.Web.Models
{
    public class FilmSearchModel
    {
        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public string Genre { get; set; }

    }
}
