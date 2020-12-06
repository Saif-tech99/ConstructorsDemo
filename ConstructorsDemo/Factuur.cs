using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    public class Factuur
    {
        public int Id; //default waarde = 0
        public string Artikel; // objecten default waarde is NULL
        public float Prijs;
        public double BTW;
        public Factuur()
        {
            BTW = 21.00;
        }

        public Factuur(int id)
            :this()//constucter chaen
        {
            Id = id;
        }
        public Factuur(int id, string artikel)
            :this(id)
        {
            this.Id = id;
            this.Artikel = artikel;
        }

        public Factuur(int id, string artikel, float prijs)
            :this(id,artikel)
        {
            this.Id = id;
            this.Artikel = artikel;
            this.Prijs = prijs;
        }

    }
}
