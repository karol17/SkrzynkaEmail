using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrzynkaEmail.app
{
    class WiadomoscWyslana : Wiadomosc
    {
        string adresOdbiorcy;

        public string AdresOdbiorcy { get => adresOdbiorcy; set => adresOdbiorcy = value; }

        public override string WyswietlSzczegoly(int id)
        {
            throw new NotImplementedException();
        }
        public void WyslijWiadomosc(Wiadomosc wiadomosc,Kontakt kontakt)
        {

        }
    }
}
