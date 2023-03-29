using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienNamespace
{
    enum HumeurChien
    {
        bonne,
        mauvaise
    }
    internal class Chien
    {
        public  string NomChien { get; set; }
        public  HumeurChien HumeurChien { get; set; }
        public string BestyD { get; set; }
        public Chien(string nomChien, HumeurChien humeurChien, string bestyD = "")
        {
            NomChien = nomChien;
            HumeurChien = humeurChien;
            BestyD = bestyD;    
        }

        public void AvoirMeilleurAmi(string best)
        {
            if (BestyD == "")
            {
                BestyD = best;
            }
            else
            {
                Console.WriteLine("Sorry " + NomChien + " a déjà un meilleur ami qui est: "+BestyD);
            }
        }

        public void ChangerMeilleur(string best)
        {
            if (BestyD != "")
            {
                BestyD = best;
            }

        }
        public override string ToString()
        {
            return $"{NomChien} est de {HumeurChien} humeur et son meilleur ami est {BestyD} \n";
        }
    }
}
