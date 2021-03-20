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

            Console.WriteLine("SIGNO = " + signo);
            



        }
    }
}
