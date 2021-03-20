using System;

namespace Validaciones
{
    public class ValidacionesNumericas
    {
        public static int solicitarNumero(string msj)
        {
            bool valido = false;
            int nro;

            do
            {
                Console.WriteLine(msj);
                if(int.TryParse(Console.ReadLine(), out nro))
                {
                    valido = true;

                } else
                {
                    msj = "Ingrese un número válido";
                }
            }
            while (!valido);
            
            
            return nro;
        }



        public static string solicitarSigno()
        {
            string opcion;
            string signo = "";

            do
            {
                Console.WriteLine("Ingrese que operación desea implementar");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Opción elegida: SUMA");
                        signo = "+";
                        break;
                    case "2":
                        Console.WriteLine("Opción elegida: RESTA");
                        signo = "-";
                        break;
                    case "3":
                        signo = "*";
                        Console.WriteLine("Opción elegida: MULTIPLICACIÓN");
                        break;
                    case "4":
                        signo = "/";
                        Console.WriteLine("Opción elegida: DIVISIÓN");
                        break;

                }
            } while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4");

            


            return signo;
        }
    }
}
