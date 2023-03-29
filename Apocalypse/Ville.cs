using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    internal class Ville
    {
        public string NomVille { get; set; }
        public Batiment[] Batiments { get; set; }

        public Ville(string nomVille, Batiment batiment1, Batiment batiment2, Batiment batiment3, Batiment batiment4, Batiment batiment5 )
        {
            Batiments = new Batiment[5];
            NomVille = nomVille;
            Batiments[0] = batiment1;
            Batiments[1] = batiment2;
            Batiments[2] = batiment3;
            Batiments[3] = batiment4;
            Batiments[4] = batiment5;

        }
    }
}
