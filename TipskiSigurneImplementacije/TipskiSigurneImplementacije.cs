using System;

namespace Vsite.CSharp
{
    public class TipskiSigurneImplementacije
    {
        public struct Duljina : IComparable
        {
            private int duljina;

            public Duljina(int duljina)
            {
                this.duljina = duljina;
            }

       
            public override string ToString()
            {
                return string.Format("{0} m", duljina);
            }

            int IComparable.CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
            public int CompareTo(Duljina d)
            {
                
                return 0;
            }
        }

        public static void Usporedi(Duljina d1, Duljina d2)
        {
            int usporedba = 0;  d1.CompareTo(d2);
            if (usporedba == 0)
                Console.WriteLine("{0} = {1}", d1, d2);
            else if (usporedba > 0)
                Console.WriteLine("{0} > {1}", d1, d2);
            else
                Console.WriteLine("{0} < {1}", d1, d2);
        }

        static void Main(string[] args)
        {
            try
            {
                // TODO: Dopuniti strukturu Duljina tako da implementira sučelje IComparable i napisati kod za metodu CompareTo.

                // TODO: U metodi Usporedi zamijeniti kraj prve naredbe zakomentiranim pozivom. 
                // TODO: U metodi Main dodati naredbu koja će metodi Usporedi proslijediti duljine d1 i d2 te provjeriti ispis.
                Duljina d1 = new Duljina(2);
                Duljina d2 = new Duljina(1);

                // TODO: Dodati naredbu koja će metodi Usporedi proslijediti d1 i string "pero". Provjeriti javlja li prevoditelj pogrešku te ako nema pogreške, pokrenuti program i provjeriti ispis.

                // TODO: Promijeniti implementaciju sučelja IComparable tako da prevoditelj javi pogrešku na usporedbu strukture Duljina i stringa. Provjeriti javlja li prevoditelj pogrešku.

                // TODO: Dopuniti strukturu Duljina tako da implementira i sučelje IComparable<Duljina>. Provjeriti javlja li prevoditelj pogrešku.

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
