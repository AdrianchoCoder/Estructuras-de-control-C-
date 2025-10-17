using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharpSena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            /* 1. Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés es del 5% anual, se debe solicitar el monto del préstamo y se desea calcular la siguiente
            información.
            • Cuanto dinero se ha pagado de intereses en un año.
            • Cuanto dinero se ha pagado de intereses en el tercer trimestre del año.
            • Cuanto dinero se ha pagado de intereses en el primer mes.
            • Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses. */

            /*float montoPrestamo, interesAño, interesMes, prestamoTotal;
            const float INTERES = 0.05f;

            Console.WriteLine("Ingresa el monto del prestamo");
            montoPrestamo = float.Parse(Console.ReadLine());

            interesAño = INTERES * montoPrestamo;
            Console.WriteLine($"Los intereses al año son: {interesAño}");

            interesMes = ((INTERES * montoPrestamo) / 4) * 3;
            Console.WriteLine($"Los intereses al tercer trimestre son: {interesMes}");

            interesMes = (INTERES * montoPrestamo) / 12;
            Console.WriteLine($"Los intereses al primer mes son: {interesMes}");

            prestamoTotal = (((INTERES * montoPrestamo) * 5) + montoPrestamo);
            Console.WriteLine($"El total pagado incluyendo los intereses es de: {prestamoTotal}");*/

            // Ejercicio 2
            /*
            2. Desarrollar un algoritmo que permita generar la colilla de pago de los empleados de una
            empresa. La colilla debe mostrar:
            ● El Salario del Empleado
            ● El Valor de Ahorro mensual programado.
            ● La suma a deducir por aporte a la Salud (EPS) 12,5 %
            ● La suma a deducir por aporte al Fondo de Pensiones 16%
            ● Total a Recibir
            ● Toda la información que debe proveer el usuario del programa es el Salario del
            Empleado y el Valor de Ahorro mensual programado. El programa debe calcular y
            devolver el resto de los datos.
             */
            /*Console.WriteLine("Cuanto es el Salario del Empleado: ");
            float salarioEmpleado = float.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto es el Valor de Ahorro Mensual que Deseas Realizar: ");
            float ahorroMensual = float.Parse(Console.ReadLine());

            float aporteSalud = 0.125f * salarioEmpleado;
            float fondoPension = 0.16f * salarioEmpleado;
            float resultadoaRecibir = aporteSalud + fondoPension + salarioEmpleado;
            float resultadoAhorroMensual = (ahorroMensual * 12);
            float resultadoTotal = resultadoaRecibir - resultadoAhorroMensual;

            Console.WriteLine($"Aporte de Salud: {aporteSalud}");
            Console.WriteLine($"Fondo de Pension: {fondoPension}");
            Console.WriteLine($"Total a Recibir con Aportes: {resultadoaRecibir}");
            Console.WriteLine($"Resultado Ahorro Mensual: {ahorroMensual}, Resultado Ahorro Mensual (Anual): {resultadoAhorroMensual}");
            Console.WriteLine($"Resultado Total Descontando el Ahorro Mensual (Anual): {resultadoTotal}");*/

            // Ejercicio 3
            /*
            PROGRAMA AGENDA:
            crear una clase llamada "Persona" con las propiedades "Nombre", "Edad" y "Género (el
            usuario deberá seleccionar
            F o M) telefono". También creara un constructor para la clase "Persona" y métodos: para
            editar la información del usuario, agregar un nuevo usuario, imprimir los detalles de la
            persona y otro para calcular la edad en días. El programa solicitará al usuario que ingrese los
            detalles de la persona y luego le permitirá elegir entre dos opciones: imprimir los detalles de
            la persona o calcular la edad en días.
            solicita al usuario que ingrese los detalles de la persona (nombre, edad y género) y luego
            crea un objeto "Persona" con esos detalles. Luego, le presenta al usuario un menú de
            opciones que le permite imprimir los detalles de la persona, calcular la edad en días o salir
            del programa. Si el usuario selecciona la opción de imprimir detalles de la persona, el
            programa llama al método "ImprimirDetalles" de la clase "Persona", que imprime los
            detalles de la persona en la consola. Si el usuario selecciona la opción de calcular edad en
            días, el programa llama al método "CalcularEdadEnDias" de la clase "Persona", que calcula la
            edad en días y la imprime en la consola
             */
        } 
    }
}
