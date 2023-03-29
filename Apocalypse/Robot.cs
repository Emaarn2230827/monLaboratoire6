using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    internal class Robot
    {
        public string CodeRobot { get; set; }
        public Piece[] Pieces { get; set; }

        public Robot (string codeRobot, Piece piece1, Piece piece2, Piece piece3)
        {
            Pieces = new Piece[3];
            CodeRobot = codeRobot;
            Pieces[0] = piece1;
            Pieces[1] = piece2;
            Pieces[2] = piece3;
        }
        public Robot()
        {
            Pieces = new Piece[3];
            CodeRobot = null;
            Pieces[0] = null;
            Pieces[1] = null;
            Pieces[2] = null;
        }

        public override string ToString()
        {
            string info = $"Code robot: {CodeRobot} \n Piece 1 :  type = {Pieces[0].TypePiece}, valeur = {Pieces[0].ValeurPiece} \n Piece 2 : type = {Pieces[1].TypePiece}, valeur = {Pieces[1].ValeurPiece} \n Piece 3 : type = {Pieces[2].TypePiece}, valeur = {Pieces[2].ValeurPiece}";
            return info;
        }
    }
}
