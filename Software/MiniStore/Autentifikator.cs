using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore
{
    public static class Autentifikator
    {
        private static Korisnik prijavljeniKorisnik;

        public static void PrijaviKorisnika(string korisnicko_ime, string lozinka)
        {
            Database entities = new Database();
            entities.Korisniks.Load();

            prijavljeniKorisnik = (from korisnici in entities.Korisniks.Local
                                  where korisnici.korisnickoIme == korisnicko_ime && korisnici.lozinka == lozinka
                                  select korisnici).SingleOrDefault();
        }

        public static void OdjaviKorisnika()
        {
            if (prijavljeniKorisnik != null) prijavljeniKorisnik = null;
        }

        public static Korisnik DohvatiPrijavljenogKorisnika()
        {
            if (prijavljeniKorisnik != null) return prijavljeniKorisnik;
            else return null;
        }

        public static int DohvatiRazinuPrijavljenogKorisnika()
        {
            if (prijavljeniKorisnik != null) return (int)prijavljeniKorisnik.vrstaKorisnika;
            else return 0;
        }
    }
}
