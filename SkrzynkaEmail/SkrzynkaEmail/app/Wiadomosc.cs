using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrzynkaEmail.app
{
    abstract class Wiadomosc
    {
        public int WiadomoscId { get; set; }
        protected string temat;
        protected string tresc;
        protected DateTime datawyslania;
        

        public string Temat { get => temat; set => temat = value; }
        public string Tresc { get => tresc; set => tresc = value; }
        public DateTime Datawyslania { get => datawyslania; set => datawyslania = value; }

        public abstract string WyswietlSzczegoly(int id);

        
    }
  
}
