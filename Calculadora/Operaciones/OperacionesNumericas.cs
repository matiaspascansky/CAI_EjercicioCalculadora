using System;

namespace Operaciones
{
    public class OperacionesNumericas
    {
        public static int suma(int nro1, int nro2)
        {
            return nro1 + nro2;
        }

        public static int resta(int nro1, int nro2)
        {
            return nro1-nro2;
        }
        public static int multiplicacion(int nro1, int nro2)
        {
            return nro1 * nro2;
        }
        public static int division(int nro1, int nro2)
        {
            int res = 0;
            if (nro2 != 0)
            {
                res =  nro1 / nro2;
            }

            return res;
        }
    }
}
