using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores matemáticos
            //% --> Resto de ladivisión entera:
            int a = 9;
            int resto = a % 2;

            //Operador + con variables de tipo byte o short
            byte n1 = 9;
            byte n2 = 10;
            short suma = (short)(n1 + n2);

            //Operadores de asignación +=
            int x = 1;
            x += 1; //x = x + 1;

            x += 9; //pasa a valer 11
            x -= 2; //pasa a valer 9;


            //Operadores relacionales
            int s1 = 9;
            int s2 = 6;

            bool condicion1 = s1 == s2; //False
            bool condicion2 = s1 != 9; //False

            Console.WriteLine("Son iguales: " + condicion1);

            //Operadores lógicos
            //lógico --> && --> A && B --> Devuelve True si A y B son True
            bool condicion3 = (9 > 5) && (9 != 0); // True
            bool condicion4 = (9 == 0) && (9 > 5); //False

            //O lógico --> || --> A || B --> Devuelve true si A o B son true
            bool condicion5 = (9 < 5) || (9 == 9); //True
            bool condicion6 = (9 < 5) || (9 % 2 == 0); //False
            bool condicion7 = (9 < 5) || (9 % 2 != 0); //True

            //No lógico ! --> Niega lo que va despúes 
            //!true = false, !false = true;



            Console.ReadLine();

        }
    }
}
