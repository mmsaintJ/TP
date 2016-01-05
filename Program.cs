using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            //ex1
            CalculSommeEntiers(1, 10);

            //ex2
            EcrireMail();


            //ex3
            CalculMoyenne();



            //ex4
            AffichageTableau();




            //ex5
            AffichageInversionValeur();


            //Ex6
            int[,] tab = new int[5, 5];
            RemplirTableau5x5(tab);
            AfficherTableau5x5(tab);
            AfficherDiagonaleTableau5x5(tab);


            //ex7
            List<double> listDouble = new List<double> { 475125, 47856932, 7412589 };
            AffichageMoyListe(listDouble);
                                        //
            Console.ReadLine();
        }



        // Ex 1 
        static void CalculSommeEntiers(int borneMin, int borneMax)
        {

            Console.WriteLine("Ex1 calculer une somme ");
            for (int i = borneMin; i <= borneMax; i++)
            {
                Console.WriteLine("{0} + {1} = {2}", borneMin, i, (borneMin + i));
            }

            Console.WriteLine();
        }


        //Ex 2
        static void EcrireMail()
        {
            Console.WriteLine("Ex2 Tronquer un mail");
            Console.WriteLine("Entrez un nom......");
            string nom = Console.ReadLine();
            if (!String.IsNullOrEmpty(nom))
                if (nom.Length > 6)
                    nom = nom.Substring(0, 6);


            Console.WriteLine(@"{0}@afpa.fr", nom);

            Console.WriteLine();
        }



        static void EcrireMail2()
        {
            Console.WriteLine("Ex2 Tronquer un mail");
            Console.WriteLine("Entrez un nom......");
            string nom = Console.ReadLine();
            if (!String.IsNullOrEmpty(nom))
                if (nom.Length > 6)
                    nom = nom.Substring(0, 6);


            Console.WriteLine(@"{0}@afpa.fr", nom);

            Console.WriteLine();
        }



        // Ex 3
        static void CalculMoyenne()
        {
            Console.WriteLine("Ex 3 : Calculer une moyenne de 3 notes");
            Console.WriteLine("Entrez un note 1......");
            string note1 = Console.ReadLine();

            Console.WriteLine("Entrez un coef 1......");
            string coef1 = Console.ReadLine();

            Console.WriteLine("Entrez un note 2......");
            string note2 = Console.ReadLine();

            Console.WriteLine("Entrez un coef 2......");
            string coef2 = Console.ReadLine();

            Console.WriteLine("Entrez un note 3......");
            string note3 = Console.ReadLine();

            Console.WriteLine("Entrez un coef 3......");
            string coef3 = Console.ReadLine();

            float moyenne = ((float.Parse(note1) * float.Parse(coef1))
                + (float.Parse(note2) * float.Parse(coef2))
                + (float.Parse(note3) * float.Parse(coef3))
                ) / (float.Parse(coef1) + float.Parse(coef2) + float.Parse(coef3));


            Console.WriteLine("la moyenne est de {0}", moyenne);
            if (moyenne > 10)
                Console.WriteLine("l'etudiant est reçu");
            else
                Console.WriteLine("l'etudiant est ajourné");
            Console.WriteLine();
            Console.WriteLine();
        }


        // Ex 4
        static void AffichageTableau()
        {
            Console.WriteLine("Ex 4 : Remplacer une valeur ds un tableau");
            int[] tabInit = { 12, 15, 13, 10, 8, 9, 13, 14 };
            bool isInserted = false;
            Console.WriteLine("Tableau avant");
            foreach (int i in tabInit)
            { Console.Write(i + " "); }

            Console.WriteLine();
            Console.WriteLine();
            do
            {


                Console.WriteLine("Entrez un indice......");
                string indice = Console.ReadLine();
                Console.WriteLine("Entrez un nombre......");
                string nombre = Console.ReadLine();
                int index = Int32.Parse(indice);
                int nb = Int32.Parse(nombre);

                Console.WriteLine();
                if (index >= 0 && index < tabInit.Length)
                {
                    isInserted = true;
                    tabInit[index] = Int32.Parse(nombre);

                    foreach (int i in tabInit)
                    { Console.Write(i + " "); }


                }
                else
                    Console.WriteLine("L'indice est incorrecte");


            } while (!isInserted);

            Console.WriteLine();
            Console.WriteLine();
        }


        // Ex 5
        static void AffichageInversionValeur()
        {

            Console.WriteLine("Ex 5 : Inversion de 2 valeur ds un tableau");
            int[] tabInit = { 12, 15, 13, 10, 8, 9, 13, 14 };
            bool isInserted = false;
            Console.WriteLine("Tableau avant");
            foreach (int i in tabInit)
            { Console.Write(i + " "); }



            Console.WriteLine();

            do
            {
                Console.WriteLine("Entrez un indice 1......");
                string indice1 = Console.ReadLine();


                Console.WriteLine("Entrez un indice 2......");
                string indice2 = Console.ReadLine();

                int index1 = Int32.Parse(indice1);
                int index2 = Int32.Parse(indice2);
                int temp = 0;
                if (index1 >= 0 && index1 < tabInit.Length && index2 >= 0 && index2 < tabInit.Length)
                {
                    isInserted = true;
                    temp = tabInit[index1];
                    tabInit[index1] = tabInit[index2];
                    tabInit[index2] = temp;

                    foreach (int i in tabInit)
                    { Console.Write(i + " "); }
                }
                else
                    Console.WriteLine("L'indice est incorrecte");
            } while (!isInserted);
            Console.WriteLine();
            Console.WriteLine();
        }

        //Ex6 methode 1 : Remplir tab
        static void RemplirTableau5x5(int[,] tab)
        {

            Console.WriteLine("Ex 6 : Remplir la matrice automatiquement");
            Random rand = new Random();
            int nombre = 0;
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    nombre = rand.Next(10);
                    tab[i, j] = nombre;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        //Ex6 methode 2 : Afficher tab
        static void AfficherTableau5x5(int[,] tab)
        {
            Console.WriteLine("Ex 6 : Afficher la matrice 5x5");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        //Ex6 methode3 : Afficher tab
        static void AfficherDiagonaleTableau5x5(int[,] tab)
        {
            Console.WriteLine("Ex 6 : Afficher la diagonale");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                        Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }



        //Ex 7
        static void AffichageMoyListe(IEnumerable<double> listDouble)
        {

            Console.WriteLine("Ex 7 : moyenne d'une liste de double");
            if (listDouble != null && listDouble.Count() > 0)
                Console.WriteLine("La moyenne est de {0}", listDouble.Average());
            else
                Console.WriteLine("Vérifier la liste....");


            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
