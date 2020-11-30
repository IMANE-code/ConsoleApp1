using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)//point d'entre
        {
            boucle();


        }
        static public void produit()
        {
            
            Console.WriteLine("Entrer le nom de produit");
            string produit = Console.ReadLine();

            Console.WriteLine("Entrer le prix de produit");
            string prixTTC = Console.ReadLine();

            Console.WriteLine("Entrer le TVA");
            string TVA = Console.ReadLine();

            double prixTVA = double.Parse( TVA)/100 * double.Parse(prixTTC);

            Console.WriteLine( "le prix de "+ produit +" TTC est de "+prixTVA+" DH");
        }

        static public void boucle()
        {
            int mult;    
            Console.WriteLine("entrer la valeur de b :");
            string b = Console.ReadLine();
            if (int.Parse(b) >= 2 && int.Parse(b) <= 100)
            {
                Console.WriteLine("La multiplication de deux valeur est:");
                for (int a = 1; a <= 30; a++)
                {
                    mult = a * int.Parse(b);
                    Console.WriteLine(mult);
                }
            }else Console.WriteLine(" valeur de b superieur de 100 ou moin à 2 ");
            }
        }

    static public void ex2()
    {

    }

 }

