using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_funciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PUNTO 2 - ARRAY O MATRIZ
            Console.WriteLine("Ingrese la cantidad de numeros:");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            float[] numeros = new float[cantidadNumeros];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero en la posicion " + (i + 1));
                numeros[i] = float.Parse(Console.ReadLine());
            }

            float promedioPositivos = Promedio(numeros);
            Console.WriteLine("El promedio de los valores positivos es: " + promedioPositivos);
            Console.ReadKey();

        }

        static float Promedio(float[] numeros)
        {
            float sumaPos = 0; //suma de los valores positivos
            int contadorPos = 0; //numeros positivos para despues dividir

            //Para recorrer el array y sumar solo los positivos
            foreach(float numero in numeros)
            {
                if(numero > 0)
                {
                    sumaPos += numero;
                    contadorPos++;
                }

            }

            //Sacar el promedio
            if(contadorPos > 0)
            {
                return sumaPos / contadorPos;
            }
            else
            {
                Console.WriteLine("No hay numeros positivos en el array");
                return 0;   
            }

        }
    }
}
