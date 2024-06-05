using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tema6Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Progama que trabaje con diez valoresde tipo int 

            int[] notas = new int[10];

            //Modificar la posición 0,3 y 7

            notas[0] = 9;
            notas[3] = 7;
            notas[7] = 5;

            //Visualizar todas las posiciones por pantalla

            //  Console.WriteLine(notas[0] + " " + notas[2] + " " + notas[3]);

            for(int i = 0; i < 10; i++)
            {
                Console.Write(notas[i] + " ");
            }

            //Hacer un programa que solicite al usuario 5 notas y las almacene en las primeras posiciones del array

            Console.WriteLine();

            //Console.Write("Ingrese la primera nota: ");
            //int nota1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese la segunda nota: ");
            //int nota2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese la tercera nota: ");
            //int nota3 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese la cuarta nota: ");
            //int nota4 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese la quinta nota: ");
            //int nota5 = Convert.ToInt32(Console.ReadLine());


            //int[] notas2 = new int[5];

            //notas2[0] = nota1;
            //notas2[1] = nota2;
            //notas2[2] = nota3;
            //notas2[3] = nota4;
            //notas2[4] = nota5;

            int[] notas2 = new int[5];
            int valor = 1;

            for(int i = 0; i < 5; i++,valor++)
            {
                Console.Write("Ingrese la nota " + valor + ": ");
                notas2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            //A continuacion calcular la media

            int suma = 0;
            
            for(int i = 0; i < 5; i++)
            {
                suma = suma + notas2[i];
            }

            int media = suma / 5;

            Console.WriteLine(media);

            if(media >= 5)
            {
                Console.WriteLine("Aprobado.");
            }
            else if (media < 5 && suma > 0)
            {
                Console.WriteLine("Suspendido");
            }
            else
            {
                Console.WriteLine("Valor no válido.");
            }

            Console.WriteLine();

            //Incizalizar una arrray con valores

            float[] temperaturas = { 1.6f, 17.5f, 12.3f, 4.5f };

            int capacidad = temperaturas.Length; // --> Obtiene la capacidad del array

            Console.WriteLine("Número de temperaturas almacenedas " + capacidad);


            Console.ReadLine();
        }
    }
}
