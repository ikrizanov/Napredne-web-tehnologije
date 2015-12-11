using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWT_Seminar.Models
{
    [DisplayName("Glumi:")]
    public class Glumac : Osoba
    {

        public virtual ICollection<Film> filmovi { get; set; }
    }
}