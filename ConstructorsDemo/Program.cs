using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factuur factuur = new Factuur();
            ////var factuur = new Factuur();
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Artikel);

            //Factuur factuur = new Factuur(2001501, "Tafel");
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Artikel);

            Factuur factuur = new Factuur(2001501);
            Console.WriteLine(factuur.Id);
            Console.WriteLine(factuur.BTW);

            //Factuur factuur = new Factuur();
            //factuur.Id = 3000300;
            //factuur.Artikel = "Tafel";
            //Console.WriteLine("{0} {1}", factuur.Id, factuur.Artikel);

            //Factuur factuur = new Factuur()
            //{
            //    Id = 234,
            //    Artikel = "tafel",
            //    Prijs = 1234.123
            //};
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Artikel);
            //Console.WriteLine(factuur.Prijs);
        }
    }
}
