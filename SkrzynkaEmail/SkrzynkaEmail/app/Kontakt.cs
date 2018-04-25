using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrzynkaEmail.app
{
    abstract class Kontakt
    {
        public  int KontaktID { get; set; } = 0;
        protected string adresEmail;
        protected string notatka;

        
        public string AdresEmail { get => adresEmail; set => adresEmail = value; }
        public string Notatka { get => notatka; set => notatka = value; }

        public abstract string WyswietlSzczegoly();

  


    }
}
