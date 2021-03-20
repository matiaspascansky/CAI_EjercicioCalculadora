using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora!");


            String mensaje = "Ingrese un número";

            int numero1=  Validaciones.ValidacionesNumericas.solicitarNumero(mensaje);
                
            mensaje = "Ingrese otro número";

            int numero2 = Validaciones.ValidacionesNumericas.solicitarNumero(mensaje);

            string signo = Validaciones.ValidacionesNumericas.solicitarSigno();

            int resultado;
            if (signo == "+")
            {
                resultado = Operaciones.OperacionesNumericas.suma(numero1, numero2);
            } else if (signo == "-")
            {
                resultado = Operaciones.OperacionesNumericas.resta(numero1, numero2);

            } else if (signo == "*")
            {
                resultado = Operaciones.OperacionesNumericas.multiplicacion(numero1, numero2);

            }
            else
            {
                resultado = Operaciones.OperacionesNumericas.division(numero1, numero2);

            }

            Console.WriteLine("EL RESULTADO ES: " + resultado);



        }
    }
}
