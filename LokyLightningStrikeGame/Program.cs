using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokyLightningStrikeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Er was eens een jonge en een meisje.");

            var allice = new persoon("Allice");
            var bob = new persoon("Bob");

            var LedLamp = new Lamp();
            var ZakLamp = new Lamp();

            Console.WriteLine("De Zaklamp brand {0}", ZakLamp.Brandend ? "" : "niet");

            
            allice.Naam = "InWonderland";
            bob.Naam = "Verhoeven";

            allice.Geboortedatum = new DateTime(2003, 4, 5);
            bob.Geboortedatum = new DateTime(1999, 5, 5);

            Console.WriteLine("allice is {0} jaar",allice.Leeftijd);

        }
    }
}
