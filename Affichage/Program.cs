using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Drawing;
using Console = Colorful.Console;
using Figgle;

namespace Affichage 
{
    internal class Program
    {
        static void TestHumain()
        {
            string test = "what the fuck";
            Console.WriteLine("1588 se lit : "+1588.ToWords());
            Console.Write(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine("\n voiture".Pluralize());
            Console.WriteLine(test.Truncate(12,"**"));
            Console.WriteLine("Voici le titre de mon livre".ToUpper()); 
        }
        
         static void TestConsole()
        {
            Console.WriteLine("Mon text en couleur",Color.Red) ;
            Console.WriteAscii("INCROYABLE", Color.FromArgb(185, 192, 255));

            //Test pour le nugget Figgle
            Console.WriteLine(FiggleFonts.Standard.Render("PRINCE DADJ"), Color.Yellow);
            Console.WriteLine(FiggleFonts.Ogre.Render($"Welcome To"));


            }

        static void Main(string[] args)
        {
            TestHumain();
            Console.WriteLine();
            TestConsole();
        }
    }
}
