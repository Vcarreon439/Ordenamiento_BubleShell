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
            Console.SetBufferSize(240, 63);
            Console.SetWindowSize(240, 63);
            Console.SetWindowPosition(0, 0);

            RBurbuja();
            Console.WriteLine("\n______________________________");
            Shell();
            Console.ReadKey();
        }

        static public void RBurbuja() 
        {
            //Arreglo a ordenar
            int[] ArrBurbu = { 4, 8, 90, 23, 1, 67, 54, 16 };
            //Copia para archivo .txt
            int[] copia1 = { 4, 8, 90, 23, 1, 67, 54, 16 };

            Console.WriteLine("Metodo Burbuja\n");
            Console.WriteLine("Arreglo original");
            //Imprime el arreglo en una linea
            ArrBurbu.ImprimirEnL();
            Console.WriteLine();
            //Metodo de Ordenamiento
            ArrBurbu.Burbuja();
            Console.WriteLine("\nArreglo Ordenado");
            ArrBurbu.ImprimirEnL();
            //Metodo para realizar un archivo de texto que muestre el procedimiento
            Utilidades.ProcedimientosBurbuja(copia1);
        }

        static public void Shell()
        {
            //Arreglo a ordenar
            int[] ArrShell = { 04, 08, 90, 23, 01, 67, 54, 16, 02, 85, 31, 114, 110, 26, 71, 38 };
            //Copia para archivo .txt
            int[] copia2 = { 04, 08, 90, 23, 01, 67, 54, 16, 02, 85, 31, 114, 110, 26, 71, 38 };

            Console.WriteLine("Metodo Shell\n");
            Console.WriteLine("Arreglo original");
            //Imprime el arreglo en una linea
            ArrShell.ImprimirEnL();
            //Metodo de Ordenamiento
            ArrShell.ShellSort();
            Console.WriteLine();
            Console.WriteLine("\nArreglo Ordenado");
            //Imprime el arreglo en una linea
            ArrShell.ImprimirEnL();
            //Metodo para realizar un archivo de texto que muestre el procedimiento
            Utilidades.ProcedimientosShell(copia2);
        }

    }
}
