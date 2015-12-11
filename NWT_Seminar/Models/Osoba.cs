using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWT_Seminar.Models
{
    public abstract class Osoba
    {
        public int ID { get; set; }
     
        public String ime { get; set; }
        public String prezime { get; set; }
        public String datumRodjena{ get; set; }

        public String ImePrezime{
            get {
                return $"{ime} {prezime}";
            }
        }

    }
}