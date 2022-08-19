// See https://aka.ms/new-console-template for more information
using Mostrar_los_pares;
using System.Globalization;
Ejercicios ej = new Ejercicios();
int opcionMenu = 0;
do
{
    Console.WriteLine("Elegi una opcion ");
    Console.WriteLine("1 - Numeros pares ");
    Console.WriteLine("2 - Numeros perfectos ");
    Console.WriteLine("3 - Probar el nombre de admin");
    Console.WriteLine("0 - Salir de la app");
    opcionMenu = Convert.ToInt32(Console.ReadLine());
    switch (opcionMenu)
    {
        case 1:
            ej.Ejercicio1();
            break;
        case 2:
            ej.Ejercicio2();
            break;
        case 3:
            ej.Ejercicio3();
            break;
    }

} while (opcionMenu != 0);
