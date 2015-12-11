using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWT_Seminar.Models
{
    public class Film
    {

        public int ID { get; set; }

        [Required]
        [DisplayName("Naslov:")]
        public String naslov { get; set; }

        [DisplayName("Opis:")]
        public String opis { get; set; }

        [DisplayName("Godina:")]
        public int godina { get; set; }
        
        public virtual Redatelj redatelj { get; set; }
        
        public virtual Scenarist scenarist { get; set; }
        
        public virtual ICollection<Glumac> glumci { get; set; }

        [DisplayName("Prosječna ocjena:")]
        public float prosjecnaOcjena { get; set; }

        public String slika { get; set; }

        public String slikaURL
        {
            get
            {
                return $"/Content/media/film-covers/{slika}";
            }
        }

        public string Prikaz { get { return $"{naslov}, {godina}"; } }

       
    }
}