using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    internal class Artikal
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public int idKategorije { get; set; }
        public int cena { get; set; }
        public string mera { get; set; }

        public Artikal(int id, string naziv, int idKategorije, int cena, string mera)
        {
            this.id = id;
            this.naziv = naziv;
            this.idKategorije = idKategorije;
            this.cena = cena;
            this.mera = mera;
        }

    }
}
