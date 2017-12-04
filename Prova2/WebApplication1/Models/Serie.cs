using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Serie
    {
        [Key]
        public String Titulo { get; set; }
        public int Temporada { get; set; }
        public int Episodio { get; set; }
        public String Sinopse { get; set; }
    }
}