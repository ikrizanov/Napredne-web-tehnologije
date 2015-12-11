
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Seminar.Models
{
    public class Korisnik
    {

        public int ID { get; set; }

        [Required]
        public String nadimak { get; set; }
        public String slika { get; set; }
        public String mail{ get; set; }
        public String lokacija { get; set; }

        public string Podaci { get { return $"{nadimak}, {lokacija}"; } }

    }
}