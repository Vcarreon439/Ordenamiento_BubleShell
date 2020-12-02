using System;
using System.IO;

namespace Ordenamiento_BubleShell
{
    class Utilidades
    {
        public static void ProcedimientosShell(int[] arreglo)
        {
            string ElementosArreglo = "";

            foreach (var item in arreglo)
                ElementosArreglo += $"{item}-";

            var fileName = $"Prueba_Shell_T{arreglo.Length}_E{ElementosArreglo}.txt";
            
            var file = new FileStream(fileName, FileMode.OpenOrCreate);

            var standardOutput = Console.Out;

            using (var writer = new StreamWriter(file))
            {
                Console.SetOut(writer);
                Console.WriteLine("---------------------------");
                Console.Write("Arreglo Original:\t");
                arreglo.Imprimir();
                Console.WriteLine("---------------------------");
                arreglo.ShellSortSteps();
                Console.WriteLine("---------------------------");
                Console.Write("Arreglo Ordenado:\t");
                arreglo.Imprimir();
                Console.WriteLine("---------------------------");
                Console.SetOut(standardOutput);
                Console.ReadKey();
            }
        }

        public static void ProcedimientosBurbuja(int[] arreglo)
        {

            string ElementosArreglo = "";

            foreach (var item in arreglo)
                ElementosArreglo += $"{item}-";

            var fileName = $"Prueba_Burbuja_T{arreglo.Length}_E{ElementosArreglo}.txt";//args[0];

            var file = new FileStream(fileName, FileMode.OpenOrCreate);

            var standardOutput = Console.Out;

            using (var writer = new StreamWriter(file))
            {
                Console.SetOut(writer);
                Console.WriteLine("---------------------------");
                Console.Write("Arreglo Original:\t");
                arreglo.Imprimir();
                Console.WriteLine("---------------------------");
                arreglo.BurbujaSteps();
                Console.WriteLine("---------------------------");
                Console.Write("Arreglo Ordenado:\t");
                arreglo.Imprimir();
                Console.WriteLine("---------------------------");
                Console.SetOut(standardOutput);
                Console.ReadKey();
            }

        }
    }
}
