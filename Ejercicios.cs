using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_los_pares
{
    class Ejercicios
    {
        /// <summary>
        /// Te pide ingresar 2 numeros y te dice cuales son pares, en caso de ninguno ser par, tambien lo notifica por pantalla
        /// </summary>
        public void Ejercicio1()
        {
            Console.WriteLine("Vas a ingresar 2 numeros, luego te mostraremos aquellos pares");
            Console.WriteLine("Toca cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("Ingresa el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool a = true;
            if (num1 % 2 == 0)
            {
                Console.WriteLine("El primer numero (" + num1 + ") es par");
            }
            else
            {
                a = false;
            }
            if (num2 % 2 == 0)
            {
                Console.WriteLine("El segundo numero (" + num2 + ") es par");
            }
            else if (!a)
            {
                Console.WriteLine("Ninguno de los números es par");
            }
        }

        /// <summary>
        /// Programa que imprime los numeros perfectos entre 1 y "n", a "n" lo debemos ingresar por teclado
        /// </summary>

        public void Ejercicio2()
        {

            Console.WriteLine("Programa que imprime los numeros perfectos entre 1 y n");
            Console.WriteLine("Ingrese \"n\" ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los numeros perfectos entre 1 y " + n + " son: ");
            for (int i = 1; i <= n; i++)
            {

                int total = 0;

                for (int j = (i - 1); j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        total += j;
                    }

                }
                if (total == i)
                {
                    Console.WriteLine(i);
                }

            }
        }
        /// <summary>
        /// Programa que te pide que ingreses el nombre del admin
        /// /// </summary>
        public void Ejercicio3()
        {
            string nombre = "";
            while (nombre != "alexis")
            {
                Console.WriteLine("Ingresa el nombre del admin");
                nombre = Console.ReadLine();
                if (nombre != "alexis")
                {
                    Console.WriteLine(nombre + " no es el nombre del admin");
                }
            }
            Console.WriteLine("Felicidades! ha ingresado el nombre del admin");

        }

        
    }
}