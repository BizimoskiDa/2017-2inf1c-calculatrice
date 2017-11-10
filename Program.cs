 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblVal1, dblVal2, dblRep = 0;
            bool isOpIncorrect = true;

            Console.WriteLine("Calculatrice;");
            Console.WriteLine("-------------");

            //Saisie des opérandes, avec vérification de ces dernières
            Console.Write("Saisir la première valeur :");
            while(!double.TryParse(Console.ReadLine(), out dblVal1))
            {
                Console.Write("Saisir à nouveau la 1ère valeur :");
            }
            
            Console.Write("Saisir la deuxième valeur :");
            while (!double.TryParse(Console.ReadLine(), out dblVal2))
            {
                Console.Write("Saisir à nouveau la 2eme valeur :");
            }

            //Saisie du choix de l'opérateur
            Console.Write("Opération à choix [+ - * / '] :");
            while (isOpIncorrect)
            {
                string strOp = Console.ReadLine();
                isOpIncorrect = false;
                switch (strOp)
                {
                    default:
                        Console.WriteLine("Opération non reconnue par le système");
                        Console.Write("Veuillez saisir à nouveau l'opérateur [+ - * / '] :");
                        isOpIncorrect = true;
                        break;
                    case "+":
                        dblRep = Outils.Addition(dblVal1,dblVal2);
                        Console.Write("La réponse : " + dblVal1.ToString());
                        break;
                    case "-":
                        dblRep = 0;
                        break;
                    case "*":
                        dblRep = 0;
                        break;
                    case "/":
                        dblRep = 0;
                        break;
                    case "'":
                        dblRep = 0;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
