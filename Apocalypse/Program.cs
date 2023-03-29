using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    internal class Program
    {
        static char ValidStart()
        {
            char choixStart = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while (choixStart != '1' && choixStart != '2')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tu dois d'abord envoyer un robot pour l'exploration");
                Console.ResetColor();
                choixStart = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            return choixStart;
        }
        static void AfficherBatiment(Game mongame)
        {
            Console.WriteLine("#####Etat de la ville##### \n");

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{mongame.LaVille.Batiments[i].ToString()}");
                Console.ResetColor();
            }
            Console.WriteLine();    
        }

        static char ValidSuite()
        {
            char choix = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while (choix != '1' && choix != '2' && choix != '3' && choix != '4' && choix != '5' && choix != '6' && choix != '7')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \n Entre une valeur valide ");
                Console.ResetColor();
                choix = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            return choix;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("\t \t \t \t ************ WELCOME TO APOCALYPSE ************");
            Console.WriteLine("\n MENU");
            Console.WriteLine(" ****");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("1- Envoyer le robot d'exploration \n");
            Console.WriteLine("2- FIN DE LA PARTIE ");
            Console.WriteLine("***************************************************************** \n");
            Game monGame = new Game();
            Robot robotDesc = null;
            Robot robotConst = null;
            Robot robotTransp = null;
            int ressource = 0;
            char choix = ValidStart();
            if(choix  == '1')
            {
                bool tours = true;
                int tour = 0;
                Robot robotExplore = monGame.InitialiserRobotExplor();
                Console.WriteLine($"Après exploration du robot, voici l'état de la ville de {monGame.LaVille.NomVille}: \n");
                AfficherBatiment( monGame);
                while (tours)
                {

                    Console.WriteLine("\n \n");
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine("1- Créer un robot destructeur pour la destruction des bâtiments\n");
                    Console.WriteLine("2- Créer un robot constructeur pour la reconstruire des bâtiments\n");
                    Console.WriteLine("3- Créer un robot Transporteur pour la recherche de ressources\n");
                    Console.WriteLine("4- Réparer un bâtiment \n");
                    Console.WriteLine("5- Détruire un bâtiment \n");
                    Console.WriteLine("6- Chercher ressource \n");
                    Console.WriteLine("7- FIN DE LA PARTIE \n");
                    Console.WriteLine("***************************************************************** \n");
                    char choix2 = ValidSuite();
                    switch (choix2)
                    {
                        case '1':
                            robotDesc = monGame.CreerLesRobots("Destructeur");
                            Console.WriteLine(robotDesc.ToString());
                            break;
                        case '2':
                            robotConst = monGame.CreerLesRobots("Constructeur");
                            Console.WriteLine(robotConst.ToString());
                            break;
                        case '3':
                            robotTransp = monGame.CreerLesRobots("Transporteur");
                            Console.Write(robotTransp.ToString());
                            break;
                        case '4':
                            if (robotConst != null)
                            {
                                AfficherBatiment(monGame);
                                Console.WriteLine("Entre le numero du bâtiment à reconstruire");
                                int numbatc = Convert.ToInt32(Console.ReadLine());
                                monGame.EvaluerEtatBatimentConst(monGame.LaVille.Batiments[numbatc - 1], ressource, monGame.LaVille.Batiments[numbatc - 1].QteRessource);
                                monGame.AfficherPourcentageConst();
                                if(ressource >= 30)
                                {
                                    ressource -= 30;
                                }
                                else
                                {
                                    ressource = 0;
                                }
                                
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vous devez d'abord créer un robot constructeur");
                                Console.ResetColor();
                            }

                            break;
                        case '5':
                            if (robotDesc != null)
                            {
                                AfficherBatiment(monGame);
                                Console.WriteLine("Entre le numero du bâtiment à detruire");
                                int numbatd = Convert.ToInt32(Console.ReadLine());
                                monGame.EvaluerEtatBatimentDest(monGame.LaVille.Batiments[numbatd - 1]);
                                monGame.AfficherPourcentageDest();
                                if (monGame.nbrePourDest == 100)
                                {
                                    Console.WriteLine($"le batiment {monGame.LaVille.Batiments[numbatd - 1].Coordonnees} a été détruit avec success ");
                                    monGame.LaVille.Batiments[numbatd - 1].StatutBat = Statut.parfait;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vous devez d'abord créer un robot destructeur");
                                Console.ResetColor();

                            }
                            break;
                        case '6':
                            if (robotTransp != null)
                            {
                                ressource += 30;
                                Console.WriteLine("ressources acquises: " + ressource);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vous devez d'abord créer un robot transporteur pour qu'il recherche les ressources");
                                Console.ResetColor();
                            }
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("*******FIN DU JEUX *********");                            
                            Console.ResetColor();
                            tours = false;
                            break;
                    }
                    tour += 1;
                }
                
                Console.WriteLine("----------------VOICI NOS ROBOTS----------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Robot Destructeur: "+robotDesc.ToString());
                Console.WriteLine("Robot Constructeur: " + robotConst.ToString());
                Console.WriteLine("Robot Transporteur: " + robotTransp.ToString());
                Console.ResetColor();

                Console.WriteLine("----------------VOICI L'ETAT DE NOTRE VILLE----------------");               
                AfficherBatiment(monGame);

                
                Console.WriteLine("----------------VOICI LE NOMBRE DE TOURS ----------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(tour);
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*******FIN DU JEUX *********");
                Console.ResetColor();
            }         
        }
    }
}
