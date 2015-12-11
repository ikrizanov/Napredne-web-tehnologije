using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NWT_Seminar.Models;

namespace NWT_Seminar.DAL
{
    public class NWT_SeminarInitializer : DropCreateDatabaseAlways<NWT_SeminarContext>
    {
        protected override void Seed(NWT_SeminarContext context)
        {
            var korisnici = new List<Korisnik>()
            {
                new Korisnik() { ID=1, nadimak = "Ivo", lokacija = "Ivić", slika = "Slicica1", mail = "macvsdil@mail.com" },
                new Korisnik() { ID=2, nadimak = "Mate", lokacija = "Matić" , slika = "Slicica4", mail = "maisdl@mail.com" },
                new Korisnik() { ID=3, nadimak = "Frane", lokacija = "Franic" , slika = "Slicica3", mail = "mavgfil@mail.com" },
                new Korisnik() { ID=4, nadimak = "Stipe", lokacija = "Stipić" , slika = "Slicica2", mail = "marfsadil@mail.com" },
                new Korisnik() { ID=5, nadimak = "Toni", lokacija = "Tonić" , slika = "Slicica5", mail = "marweil@mail.com" }
            };
            korisnici.ForEach( kor => context.Korisnici.Add(kor));

            var sc = new List<Scenarist>()
            {
                new Scenarist() {ID = 1, ime = "Ivo", prezime = "Ivić", datumRodjena = "10.10.1990." },
                new Scenarist() {ID = 2, ime = "IvicaScen2", prezime = "Horvat", datumRodjena = "10.1.1970." },
                new Scenarist() {ID = 3, ime = "AnteScen3", prezime = "Hrvat", datumRodjena = "11.10.1980." }
            };
            sc.ForEach(o => context.Scenaristi.Add(o));

            var gl = new List<Glumac>()
            {
                new Glumac() { ID = 4, ime = "Marko", prezime = "Markic", datumRodjena = "10.11990." },
                new Glumac() { ID = 5, ime = "Matko", prezime = "Matkic", datumRodjena = "10.145.1970." },
                new Glumac() { ID = 6, ime = "Branko", prezime = "Brankic", datumRodjena = "10.145.1970." },
                new Glumac() { ID = 7, ime = "Zrinka", prezime = "Zrinkic", datumRodjena = "10.145.1970." },
                new Glumac() { ID = 8, ime = "Lucija", prezime = "Lucic", datumRodjena = "10.145.1970." },
                new Glumac() { ID = 9, ime = "Darko", prezime = "Darkic", datumRodjena = "10.145.1970." },
                new Glumac() { ID = 10, ime = "Andreja", prezime = "Andric", datumRodjena = "11.1450." }
            };
            gl.ForEach(o => context.Glumci.Add(o));

            var re = new List<Redatelj>()
            {
                new Redatelj() { ID = 7, ime = "Ana", prezime = "Anić", datumRodjena = "10.ft23." },
                new Redatelj() { ID = 8, ime = "Anita", prezime = "Anitić", datumRodjena = "10.3.1970." },
                new Redatelj() { ID = 9, ime = "Marina", prezime = "Marinič", datumRodjena = "11.2f." }
            };
            re.ForEach(o => context.Redatelji.Add(o));
            


            var fil = new List<Film>()
            {
                new Film() {
                    naslov = "Shutter Island",
                    opis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque fringilla nunc vitae massa accumsan, non efficitur ipsum fringilla. Vivamus in ornare elit. Mauris gravida, risus vel dapibus rutrum, tellus libero vestibulum erat, et vulputate orci velit nec erat. Nam quis vestibulum nisl. In aliquet nec urna a tincidunt. Aenean sit amet consequat lorem. Proin auctor dolor aliquam, lacinia orci sed, ultricies orci. Integer iaculis consectetur enim id tempus. ",
                    godina = 2011,
                    redatelj = re[0],
                    scenarist = sc[0] ,
                    glumci = new List<Glumac>() { gl[2], gl[1] } ,
                    prosjecnaOcjena = 2,
                    slika = "SI.jpg"
                },
                new Film() {
                    naslov = "Titanic",
                    opis = "Curabitur in felis vestibulum, dapibus ligula eget, sagittis ligula. Mauris hendrerit pulvinar risus, eu lobortis risus lacinia at. Aliquam in sodales tellus, molestie pellentesque massa. Morbi eu nibh at elit pretium vulputate. Donec elementum eleifend felis, eget lobortis erat tempor nec. Cras nec turpis ullamcorper, ullamcorper nibh auctor, pulvinar lectus. Vivamus in nibh ex.",
                    godina = 2012,
                    redatelj = re[1],
                    scenarist = sc[0] ,
                    glumci = new List<Glumac>() { gl[0], gl[2] } ,
                    prosjecnaOcjena = 3 ,
                    slika = "2.jpg"
                },
                new Film() {
                    naslov = "Wolf From The Wall Street",
                    opis = "Aliquam elementum sapien nibh, non pulvinar lacus faucibus et. Nullam non enim orci. Ut sit amet commodo neque, sit amet pharetra turpis. Nulla fringilla metus eget faucibus pretium. Integer commodo nisi convallis massa gravida, nec accumsan enim tincidunt. Curabitur eu risus id ipsum vestibulum convallis. Nunc semper, erat eget sagittis vulputate, urna turpis imperdiet arcu, ut laoreet arcu ipsum eu arcu. ",
                    godina = 2014,
                    redatelj = re[2],
                    scenarist = sc[2] ,
                    glumci = new List<Glumac>() { gl[3], gl[4] },
                    prosjecnaOcjena = 4 ,
                    slika = "3.jpg"
                },
                new Film() {
                    naslov = "James Bond",
                    opis = "Pellentesque sollicitudin eleifend dui, nec congue orci mattis vel. Donec sem libero, condimentum nec sollicitudin blandit, venenatis nec odio. Curabitur maximus eu justo eu ullamcorper. Nulla eget tortor mauris. In placerat lectus eget molestie luctus. Aenean non augue dolor. Maecenas venenatis vulputate sem, non faucibus mauris vulputate quis.",
                    godina = 2015,
                    redatelj =  re[2],
                    scenarist = sc[1] ,
                    glumci = new List<Glumac>() { } ,
                    prosjecnaOcjena = 5,
                    slika = "4.jpg"
                },
                new Film() {
                    naslov = "Frozen",
                    opis = "Mauris ut dolor rutrum, ultrices justo eget, pretium mi. Proin viverra purus eu ullamcorper placerat. Suspendisse non nisl ut sapien lacinia suscipit nec ut odio. Suspendisse orci lorem, auctor imperdiet ornare nec, varius in velit. Curabitur varius malesuada magna, ac fermentum sem posuere sit amet. Ut non ante magna.",
                    godina = 2016,
                    redatelj =  re[2],
                    scenarist = sc[1] ,
                    glumci = new List<Glumac>() { gl[5], gl[6] } ,
                    prosjecnaOcjena = 1,
                    slika = "5.jpg"
                }
            };

            fil.ForEach(o => context.Filmovi.Add(o));

            context.SaveChanges();
        }
    }
}