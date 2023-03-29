using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    internal class Game
    {
        public Usine MonUsine { get; set; }    
        public Ville LaVille { get; set; }
        public int nbrePourConst = 0;
        public int nbrePourDest = 0;

        public Game()
        {
            MonUsine = new Usine("matrix");
            LaVille = CreerVille();
        }   
        public Robot InitialiserRobotExplor()
        {
            Robot robExp = MonUsine.CreerRobot();
            return robExp;
        }

        private Ville CreerVille()
        {
            Batiment bat1 = new Batiment("Bt1",Statut.parfait,1);
            Batiment bat2 = new Batiment("Bt2",Statut.necc_reparation,4,55);
            Batiment bat3 = new Batiment("Bt3",Statut.etre_demoli,2);
            Batiment bat4 = new Batiment("Bt4",Statut.necc_reparation,5,60);
            Batiment bat5 = new Batiment("Bt5",Statut.etre_demoli,3);
            Ville city = new Ville("Yaounde", bat1, bat2, bat3, bat4, bat5);

            return city;
        }
        public void  EvaluerEtatBatimentConst(Batiment batiment,int nbreRessource, int besoinressource) 
        {
            
            if (batiment.StatutBat == Statut.necc_reparation && nbreRessource >= besoinressource)
            {
                nbrePourConst += 10;              
            }
            else if(batiment.StatutBat == Statut.necc_reparation && nbreRessource < besoinressource)
            {
                nbrePourConst += 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vous n'avez pas asser de ressources");
                Console.ResetColor();   
            }
            else 
            {
                Console.WriteLine("Ce bâtiment ne peut pas être construit");
            }
        }

        public void EvaluerEtatBatimentDest(Batiment batiment)
        {
          
            if (batiment.StatutBat == Statut.etre_demoli)
            {  
                nbrePourDest += 20;
            }
            else
            {
                Console.WriteLine("Ce bâtiment ne peut pas être détruit");
            }
        }

        public void AfficherPourcentageConst()
        {
            Console.WriteLine($"Le pourcentage  de construction est de : {nbrePourConst}%");
        }

        public void AfficherPourcentageDest()
        {
            Console.WriteLine($"Le pourcentage  de destruction est de : {nbrePourDest}%");
        }

        public Robot CreerLesRobots(string typeRobot)
        {
            Robot robot = new Robot();
            if(typeRobot == "Constructeur")
            {
                Piece crobot1 = new Vitesse("Vitesse", 19);
                Piece crobot2 = new Transport("Transport", 15);
                Piece crobot3 = new Construction("Construction", 18);
                robot = MonUsine.CreerRobot(crobot1,crobot2,crobot3);
            }
            else if(typeRobot == "Destructeur")
            {
                Piece drobot1 = new Vitesse("Vitesse", 19);
                Piece drobot2 = new Transport("Transport", 15);
                Piece drobot3 = new Destruction("Destruction", 17);
                robot = MonUsine.CreerRobot(drobot1, drobot2, drobot3);
            }
            else if (typeRobot == "Transporteur")
            {
                Piece trobot1 = new Vitesse("Vitesse", 19);
                Piece trobot2 = new Transport("Transport", 15);
                Piece trobot3 = new Transport("Transport", 15);
                robot = MonUsine.CreerRobot(trobot1, trobot2, trobot3);
            }
            return robot;
        }
    }
}
