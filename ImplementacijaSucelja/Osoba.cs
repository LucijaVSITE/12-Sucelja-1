using System;

namespace Vsite.CSharp
{
    public class Osoba : IComparable<Osoba> 
    {
        public Osoba(string ime, string prezime, DateTime datumRođenja, string mjestoRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
            MjestoRođenja = mjestoRođenja;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, {3}", Ime, Prezime, DatumRođenja.ToShortDateString(), MjestoRođenja);
        }

        public int CompareTo(Osoba other)
        {
            int rez = Prezime.CompareTo(other.Prezime);
            if (rez != 0)
                return rez;
            return Ime.CompareTo(other.Ime);
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
