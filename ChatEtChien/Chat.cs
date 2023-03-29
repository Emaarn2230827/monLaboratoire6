using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNamespace
{
    enum HumeurChat
    {
        bonne,
        mauvaise
    }
    internal class Chat
    {
        public string NomChat { get; set; }
        public HumeurChat HumeurChat { get; set; }
        public string BestyC { get; set; }
         public Chat(string nomChat, HumeurChat humeurChat, string bestyc = "")
        {
            NomChat = nomChat;
            HumeurChat = humeurChat;
            BestyC = bestyc;
        }   

        public void AvoirMeilleurAmi(string best)
        {
            if (BestyC == "")
            {
                BestyC =best;
            }
            else
            {
                Console.WriteLine("Sorry " +NomChat + " a déjà un meilleur ami qui est: "+ BestyC);
            }
        }

        public void ChangerMeilleur(string best)
        {
            if (BestyC != "")
            {
                BestyC = best;
            }

        }

        public override string ToString()
        {
            return $"{NomChat} est de {HumeurChat} humeur et son meilleur ami est {BestyC} \n";
        }
    }
}
