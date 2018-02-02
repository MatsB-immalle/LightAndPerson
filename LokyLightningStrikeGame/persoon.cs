using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokyLightningStrikeGame
{
    class persoon
    {
        public persoon(string voornaam)
        {
            Voornaam = voornaam;

            Console.WriteLine("{0}: He ik leef!", voornaam);

        }

        public string Voornaam { get; }
        public string Naam { get; set; }
        public string Postcode { get; set; }
        public DateTime Geboortedatum { get; set; }

        public int Leeftijd
        {
            get
            {
                var ts = DateTime.Now - Geboortedatum;
                return (int)(ts.TotalDays / 365);

            }


        }
    }    
}
