using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatNamespace;
using ChienNamespace;

namespace AmitieNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat monchat = new Chat("cat",HumeurChat.bonne);
            Chien monChien1 = new Chien("Dog", HumeurChien.bonne);
            Chien monChien2 = new Chien("Doggy", HumeurChien.bonne);
            if(monchat.HumeurChat == HumeurChat.bonne)
            {
                Console.WriteLine("****************Etat des animaux************ \n");
                monchat.AvoirMeilleurAmi(monChien1.NomChien);
                monChien1.AvoirMeilleurAmi(monchat.NomChat);
                monChien1.ChangerMeilleur(monChien2.NomChien);
                monChien2.AvoirMeilleurAmi(monChien1.NomChien);
               Console.WriteLine( monchat.ToString());
               Console.WriteLine( monChien1.ToString());
                Console.WriteLine(monChien2.ToString());
                monChien2.AvoirMeilleurAmi(monchat.NomChat);
                Console.WriteLine(monChien2.ToString());
            }
            
        }
    }
}
