using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_BubleShell
{
    class Program
    {
        static void Main(string[] args)
        {
            RBurbuja();
            Console.WriteLine("\n______________________________");
            Shell();
            Console.ReadKey();
        }

        static public void RBurbuja() 
        {
            int[] ArrBurbu = { 15, 67, 08, 16, 44, 27, 12, 35 };
            int[] copia = { 15, 67, 08, 16, 44, 27, 12, 35 };

            Console.WriteLine("Metodo Burbuja\n");
            Console.WriteLine("Arreglo original");
            ArrBurbu.ImprimirEnL();
            Console.WriteLine();
            ArrBurbu.Burbuja();
            Console.WriteLine("\nArreglo Ordenado");
            ArrBurbu.ImprimirEnL();

            Utilidades.ProcedimientosBurbuja(copia);
        }

        static public void Shell()
        {
            int[] ArrShell = { 04, 08, 90, 23, 01, 67, 54, 16, 02, 85, 31, 114, 110, 26, 71, 38 };
            int[] copia = { 04, 08, 90, 23, 01, 67, 54, 16, 02, 85, 31, 114, 110, 26, 71, 38 };

            Console.WriteLine("Metodo Shell\n");
            Console.WriteLine("Arreglo original");
            ArrShell.ImprimirEnL();
            ArrShell.ShellSort();
            Console.WriteLine();
            Console.WriteLine("\nArreglo Ordenado");
            ArrShell.ImprimirEnL();

            Utilidades.ProcedimientosShell(copia);
        }

    }
}
