using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Unity2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Atelier a = new Atelier();
            Cabane c = new Cabane();
            Maison m = new Maison();
            Hdv h = new Hdv();
            Environment e = new Environment(c, a, h, m);
            

            String choix;
            
            String replay;
            do
            {
                do
                {

                    Console.WriteLine(e);

                    Console.WriteLine("1. Visualiser environement");
                    Console.WriteLine("2. Construire un bâtiment");
                    Console.WriteLine("3. Améliorer un bâtiment");
                    Console.WriteLine("4. Fin de tour");
                    Console.WriteLine("5. Quitter");
                    choix = Console.ReadLine();

                    switch (choix)
                    {
                        case "1":

                            Console.WriteLine(e.DétailBatiment());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "2":
                            
                            String construct;
                            Console.WriteLine("Construire un batiment :");
                            Console.WriteLine("1. Cabane");
                            Console.WriteLine("2. Atelier");
                            Console.WriteLine("3. Maison");
                            construct = Console.ReadLine();
                            switch (construct)
                            {
                                case "1":
                                    if (e.ConstructibleTier1())
                                        e.ConstructionCabane();
                                    else
                                        Console.WriteLine("il nous faut plus de bois");
                                    break;
                                case "2":
                                    if (e.ConstructibleTier1())
                                        e.ConstructionAtelier();
                                    else
                                        Console.WriteLine("il nous faut plus de bois");
                                    break;
                                case "3":
                                    if (e.ConstructibleTier1())
                                        e.ConstructionMaison();
                                    else
                                        Console.WriteLine("il nous faut plus de bois");
                                    break;

                                         
                            }
                            Console.ReadLine();
                            Console.Clear();

                            break;
                        case "3":
                            String upgrade;
                            Console.WriteLine("Améliorer un batiment :");
                            Console.WriteLine("1. Cabane");
                            Console.WriteLine("2. Atelier");
                            Console.WriteLine("3. Maison");
                            upgrade = Console.ReadLine();
                            switch (upgrade)
                            {
                                case "1":

                                    e.BankMp-=e.LaCabane.MonterDeNiveau();
                                    e.LaCabane.PrixUp();
                                    e.Population();
                                    e.StartFish();
                                    Console.WriteLine("La cabanne passe au niveau " + e.LaCabane.LvlBatiment + "!!!!!");
                                    
                                    break;
                                case "2":
                                    e.BankMp -= e.LAtelier.MonterDeNiveau();
                                    e.LAtelier.PrixUp();
                                    e.Population();
                                    e.StartFish();
                                    Console.WriteLine("L'atelier passe au niveau " + e.LAtelier.LvlBatiment + "!!!!!");
                                   
                                    break;
                                case "3":
                                    e.BankMp -= e.LaMaison.MonterDeNiveau();
                                    e.LaMaison.PrixUp();
                                    e.Population();
                                    e.StartFish();
                                    Console.WriteLine("La maison passe au niveau " + e.LaMaison.LvlBatiment + "!!!!!");
                                    
                                    break;

                            }
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "4":
                            e.EndTurn();
                            Console.Clear();
                            
                            break;



                    }
                    if (e.Win)
                    {
                        Console.WriteLine("Win!!!!");
                        break;
                    }
                    if (e.Lose)
                    {
                        
                        Console.WriteLine("Lose!!!!");
                        break;
                    }

                } while (choix != "5");
                Console.WriteLine("je suis sortie");
                
                Console.WriteLine("Rejouer? O/n");
                replay = Console.ReadLine();
                e = new Environment(c, a, h, m);
                Console.Clear();
            } while (replay.ToUpper() == "O");

        }
    }
}
