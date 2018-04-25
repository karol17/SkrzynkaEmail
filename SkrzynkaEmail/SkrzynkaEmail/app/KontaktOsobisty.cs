using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrzynkaEmail.app
{
    class KontaktOsobisty : Kontakt
    {
        private string Imie;
        private string Nazwisko;

        public string Imie1 { get => Imie; set => Imie = value; }
        public string Nazwisko1 { get => Nazwisko; set => Nazwisko = value; }

        
     

       

        public override string WyswietlSzczegoly()
        {
            throw new NotImplementedException();
        }
    }
}
