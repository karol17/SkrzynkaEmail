using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrzynkaEmail.app
{
    class KontaktFirmowy : Kontakt
    {
        private string nazwaInstytucji;

        public string NazwaInstytucji { get => nazwaInstytucji; set => nazwaInstytucji = value; }

        public override string WyswietlSzczegoly()
        {
            return nazwaInstytucji + "\nEmail:" + adresEmail + "\nNotatka:" + "\n" + notatka;
        }
    }
}
