using System;

namespace tri_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programme de tri d'un tableau");
            int[] tableau = { 9, 10, 45, 0, 6 };
            for (int i=0;i<tableau.Length; i++)
            {
                int nbmin = 0;
                int index = 0;
                for (int y = i; y < tableau.Length; y++) 
                {
                    if (y == i || tableau[y] < nbmin) 
                    {
                        nbmin = tableau[y];
                        index = y;
                    }
                }
                tableau[index] = tableau[i];
                tableau[i] = nbmin;
            }
            foreach (int number in tableau )
            {
                Console.WriteLine(number);
            }
        }
    }
}
