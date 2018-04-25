using SkrzynkaEmail.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrzynkaEmail.data
{
    class ListaKontaktow
    {
        List<Kontakt> kontakty;

        public ListaKontaktow()
        {
            kontakty = new List<Kontakt>();
        }
        public IEnumerable<Kontakt> WyswietlKontakty()
        {
            foreach(var item in kontakty)
            {
                yield return item;
            }
        }
        public void DodajKontaktOsobisty(KontaktOsobisty kontakt)
        {
            kontakty.Add(kontakt);
        }
        public void DodajKontaktFirmowy(KontaktFirmowy kontakt)
        {
            kontakty.Add(kontakt);
        }
        public void UsunKontakt(int id)
        {
            var kontakt = kontakty.FirstOrDefault(k => k.KontaktID == id);
            kontakty.Remove(kontakt);
        }
        public string WyswietlSzczegoly(int id)
        {
            var kontakt= kontakty.FirstOrDefault(k => k.KontaktID == id);
            return kontakt.WyswietlSzczegoly();
        }
    }
}
