using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talle1_Funcion1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //TALLER - FUNCIONES
            //Punto 15

            Console.WriteLine("Ingrese la palabra que quiere verificar: ");
            string palabra = Console.ReadLine();

            //Console.WriteLine(palabra);
            //Console.WriteLine(Reversa(palabra));
            //Console.ReadKey();

            
            EsPalindroma(palabra, Reversa(palabra));
            Console.ReadKey();
            

        }

        

        static string Reversa(string palabra)
        {
            string palabraR = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraR += palabra[i];
            }

            return palabraR;
        }



        static bool EsPalindroma(string palabra, string palabraR)
        {
            
            
            for(int i = 0; i < palabra.Length; i++)
            {
                if(palabraR[i] != palabra[i])
                {

                    Console.WriteLine("Esta palabra no es palíndroma :(");
                    return false;
                }
                else
                {
                    i++;
                    
                }

               
            }

            Console.WriteLine("La palabra ingresada es un palíndromo!");
            return true;

          
        }
    }
}
