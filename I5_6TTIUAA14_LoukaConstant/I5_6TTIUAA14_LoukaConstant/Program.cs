using System.Diagnostics;

namespace I5_6TTIUAA14_LoukaConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Bienvenue dans ce jeu de tir ... Vous démarrez avec 30 balles");
            Console.WriteLine("============================================================================");
            string nUser;
            
            do
            {
                Console.WriteLine("Espace pour tirer, \n");
                Console.WriteLine("r pour recharger \n");
                Console.WriteLine("v pour voir combien il reste de munitions en poche et dans le chargeur, \n");
                Console.WriteLine("+ pour reprendre des munitions, \n");
                Console.WriteLine("q pour quitter \n");
                Console.WriteLine("--->");
                nUser = Console.ReadLine();
                PaintBallGun paintBallGun = new PaintBallGun(0, 16);
                Joueur joueur = new Joueur("test", paintBallGun, 30);

                if (nUser == " ")
                {
                   
                }

                if (nUser == "r")
                {
                    Console.WriteLine(joueur.Recharge());
                }

                if (nUser == "v")
                {
                    Console.WriteLine(joueur.VerifiePoche());
                }

                if (nUser == "+")
                {

                }

                
            } while (nUser == "q");

            
            

        }
    }
}