using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    internal class Kategorija
    {
        private int id { get; set; }
        private string ime { get; set; }

        public Kategorija(int id, string ime)
        {
            this.id = id;
            this.ime = ime;
        }
    }
}
