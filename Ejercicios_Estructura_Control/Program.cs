using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Estructura_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Ingresa un Numero: ");
                var numeroEntero = Convert.ToInt32(Console.ReadLine());
                if (numeroEntero % 2 == 0)
                {
                    Console.WriteLine("El Numero es Par!");
                }
                else
                {
                    Console.WriteLine("El Numero es Impar!");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Ocurrio un Error: {error.Message}");
            }
            */

            /*
            float nota1, nota2, nota3;
            Console.WriteLine("Ingresa la Primera nota");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la Segunda nota");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la Tercera nota");
            nota3 = float.Parse(Console.ReadLine());
            if (nota1 < 1 || nota1 > 5 || nota2 < 1 || nota2 > 5 ||  nota3 < 1 || nota3 > 5)
            {
                Console.WriteLine("Error Verfica Colocar la Informacion Correcta");
            }
            else
            {
                var resultadoFinal = (nota1 * 0.20) + (nota2 * 0.30) + (nota3 * 0.50);
                if (resultadoFinal > 3)
                {
                    Console.WriteLine($"Aprobaste: {resultadoFinal}");
                }
                else
                {
                    Console.WriteLine($"No Aprobaste: {resultadoFinal}");
                }
        
            }
            */

            Console.WriteLine("Ingresa el Nombre del Producto: ");
            var nombreProducto = Console.ReadLine();
            Console.WriteLine("Ingresa el Valor del Producto");
            var valorProducto = float.Parse(Console.ReadLine());

            if (valorProducto >= 100000)
            {
                var descuento = valorProducto * 0.20f;
                Console.WriteLine($"El Nombre del Producto es: {nombreProducto}, El Valor Final del Producto es: {descuento:C2}");
            }
            else if (valorProducto < 1)
            {
                Console.WriteLine("Error Verfica que el Valor del Producto este dentro del Rango...");
            }
            else
            {
                Console.WriteLine($"El Nombre del Producto es: {nombreProducto}, El Valor del Producto es: {valorProducto:C}");
            }


            Console.ReadKey();
        }
    }
}
