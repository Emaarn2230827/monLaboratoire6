using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
   
    internal class Usine
    {
        public string Coordonnees { get; set; }
        private int nbreRobot= 1;
        public Usine(string coord)
        {
            Coordonnees = coord;
        }

        public Robot CreerRobot()
        {
            Piece vitesserobot1 = new Vitesse("Vitesse",19);
            Piece vitesserobot2 = new Vitesse("Vitesse", 18);
            Piece vitesserobot3 = new Vitesse("Vitesse", 19);
            Robot robotexplore = new Robot("exp1", vitesserobot1, vitesserobot2, vitesserobot3);
            return robotexplore;    
        }
        public Robot CreerRobot(Piece piece1, Piece piece2, Piece piece3)
        {
            Robot robot = new Robot("rb"+nbreRobot, piece1, piece2, piece3);
            nbreRobot++;
            return robot;
        }
    }
}
