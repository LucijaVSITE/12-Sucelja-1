using System;

namespace Vsite.CSharp
{
    public class VirtualniČlanovi
    {
        public interface ISučelje
        {
            string NevirtualnaMetoda();
            string VirtualnaMetoda();
        }

        // Definirajte klasu Bazna tako da implementira sučelje ISučelje. Metoda NevirtualnaMetoda neka vraća "Bazna.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Bazna.VirtualnaMetoda".
        public class Bazna : ISučelje
        {
            public string NevirtualnaMetoda()
            {
                return "Bazna.NevirtualnaMetoda";
            }

            public virtual string VirtualnaMetoda()
            {
                return "Bazna.VirtualnaMetoda";
            }
        }


        //  Definirajte klasu Izvedena da je izvedena iz klase Bazna te u klasi Izvedena pregazite (override) metode iz ISučelja. Metoda NevirtualnaMetoda neka vraća "Izvedena.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Izvedena.VirtualnaMetoda".
        //  Provjerite poruke o pogreškama ili upozorenja prevoditelja.
        public class Izvedena : Bazna, ISučelje
        {
            public new string NevirtualnaMetoda()
            {
                return "Izvedena.NevirtualnaMetoda";
            }

            public  override string VirtualnaMetoda()
            {
                return "Izvedena.VirtualnaMetoda";
            }
        }

        public static void PozoviNevirtualnuMetodu(ISučelje sučelje)
        {
            Console.WriteLine(sučelje.NevirtualnaMetoda());
        }

        public static void PozoviVirtualnuMetodu(ISučelje sučelje)
        {
            Console.WriteLine(sučelje.VirtualnaMetoda());
        }

        static void Main(string[] args)
        {
            // Inicijalizirajte objekt instancom klase Bazna te provjerite ispis
            ISučelje s1 = new Bazna();
            PozoviNevirtualnuMetodu(s1);
            PozoviVirtualnuMetodu(s1);

            // Inicijalizirajte objekt instancom klase Izvedena te provjerite ispis
            ISučelje s2 = new Izvedena();
            PozoviNevirtualnuMetodu(s2);
            PozoviVirtualnuMetodu(s2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
