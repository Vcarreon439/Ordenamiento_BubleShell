using System;

namespace Ordenamiento_BubleShell
{
    public static class MetodosOrdenamiento
    {
        /// <summary>
        /// Metodo para llenar un arreglo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo"></param>
        /// /// <param name="tamaño"></param>
        public static void Llenar<T>(this T[] arreglo) where T : IComparable<T>
        {
            Random rdm = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                T newval = (T)(Object)rdm.Next(0, 100000);
                arreglo[i] = newval;
            }
        }

        public static void Llenar<T>(this T[] arreglo, int tamaño) where T : IComparable<T>
        {
            arreglo = new T[tamaño];
            Random rdm = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                T newval = (T)(Object)rdm.Next(0, tamaño);
                arreglo[i] = newval;
            }
        }



        /// <summary>
        /// Método Burbuja implementado como extensión
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arreglo a ordenar</param>
        public static void Burbuja<T>(this T[] arreglo) where T : IComparable<T>
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = arreglo.Length - 1; j > i; j­­--)
                {
                    if (arreglo[j - 1].CompareTo(arreglo[j]) > 0)
                        arreglo.Cambio(j - 1, j);
                }
            }
        }

        public static void BurbujaSteps<T>(this T[] arreglo) where T : IComparable<T>
        {
            int iteracion = 0;
            int cambios = 0;

            for (int i = 0; i < arreglo.Length; i++) 
            {
                Console.WriteLine($"Iteracion #{iteracion}, cambios {cambios}");
                Console.WriteLine("_______________________________________________________");

                for (int j = arreglo.Length-1; j > i; j--) 
                {

                    bool comp = false;

                    if (arreglo[j - 1].CompareTo(arreglo[j]) > 0)
                    {
                        comp = true;
                        arreglo.Cambio(j, j-1);
                        cambios++;
                        Console.WriteLine($"Hay intercambio? [{(j-1)+1}]{arreglo[j]} > [{j+1}]{arreglo[j-1]} | {comp}");
                    }
                    else 
                    {
                        Console.WriteLine($"Hay intercambio? [{(j-1)+1}]{arreglo[j-1]} > [{j+1}]{arreglo[j]} | {comp}");
                    }

                }
                Console.WriteLine();
                arreglo.ImprimirEnL();
                Console.WriteLine();
                iteracion++;
            }

        }

        /// <summary>
        /// Intercambia 2 elementos de un arreglo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arrglo a modificar</param>
        /// <param name="valor1">Posicion del elemento 1</param>
        /// <param name="valor2">Posicion del elemento 2</param>
        private static void Cambio<T>(this T[] arreglo, int valor1, int valor2) where T : IComparable<T>
        {
            //Verificar dentro del rango
            if (arreglo.Length <= valor2 || arreglo.Length <= valor1)
                throw new IndexOutOfRangeException();

            //Intercambio
            T temporal = arreglo[valor1];
            arreglo[valor1] = arreglo[valor2];
            arreglo[valor2] = temporal;
        }

        /// <summary>
        /// Método ShellSort implementado como extensión
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arreglo a ordenar</param>
        public static void ShellSort<T>(this T[] arreglo) where T : IComparable<T>
        {
            // Distancia entre elementos que se van a comparar
            var d = arreglo.Length / 2;
            
            while (d >= 1)
            {
                for (var i = d; i < arreglo.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (arreglo.EsMayorQue(j, j - d)))
                    {
                        arreglo.Cambio(j, (j - d));
                        j = j - d;
                    }
                }
                d = d / 2;
            }
        }


        public static void ShellSortSteps<T>(this T[] arreglo) where T : IComparable<T> 
        {
            // Distancia entre elementos que se van a comparar
            var d = arreglo.Length / 2;



            while (d >= 1)
            {
                bool happen = false;

                for (var i = d; i < arreglo.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (arreglo.EsMayorQue(j, j - d)))
                    {
                        happen = true;
                        arreglo.Cambio(j, (j - d));
                        j = j - d;
                    }
                }

                if (happen)
                {
                    Console.Write("La ordenacion produce: ");
                    arreglo.Imprimir();
                    Console.WriteLine();
                }
                d = d / 2;
            }
        }

        /// <summary>
        /// Metodo de ordenamiento RadixSort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arreglo que se va a ordenar</param>
        public static void RadixSort<T>(this T[] arreglo) where T : IComparable<T>
        {
            //Arreglo temporal del mismo tamaño que el del original
            int[] temp = new int[arreglo.Length];


            for (int shift = 31; shift > -1; shift--)
            {
                int j = 0;

                for (int i = 0; i < arreglo.Length; i++)
                {
                    bool mover = (Convert.ToInt32(arreglo[i]) << shift) >= 0;

                    if (shift == 0 ? !mover : mover)
                    {
                        arreglo[i - j] = arreglo[i];
                    }
                    else
                    {
                        temp[j++] = Convert.ToInt32(arreglo[i]);
                    }
                }
                Array.Copy(temp, 0, arreglo, arreglo.Length - j, j);
            }
        }


        /// <summary>
        /// Metodo QuickSort de ordenamiento.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vector">Arreglo a ordenar</param>
        /// <param name="primero">Desde</param>
        /// <param name="ultimo">Hasta</param>
        public static void QuickSort<T>(this T[] vector, int primero, int ultimo) where T : IComparable<T>
        {
            //Variables de control
            int i = primero, j = ultimo, central = (primero + ultimo) / 2;
            //Elemento de en "medio"
            int pivote = Convert.ToInt32(vector[central]);

            //Ciclo para realizar el ordenamiento
            do
            {
                //While para determinar la cantidad de movimientos en los elementos menores a pivote
                while (Convert.ToInt32(vector[i]) < pivote) i++;
                //While para determinar la cantidad de movimientos en los elementos mayores a pivote
                while (Convert.ToInt32(vector[j]) > pivote) j--;

                if (i <= j)
                {
                    //Enroque
                    vector.Cambio(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
                vector.QuickSort(primero, j);

            if (i < ultimo)
                vector.QuickSort(i, ultimo);

        }


        /// <summary>
        /// Comparación entre 2 elementos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo"></param>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns>Booleano que establece si es mayor</returns>
        private static bool EsMayorQue<T>(this T[] arreglo, int valor1, int valor2) where T : IComparable<T>
        {
            bool result = false;

            if (Convert.ToInt32(arreglo[valor1]) < Convert.ToInt32(arreglo[valor2]))
                result = true;

            return result;
        }

        /// <summary>
        /// Comparación entre 2 elementos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo"></param>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns>Booleano que establece si es menor</returns>
        private static bool EsMenorQue<T>(this T[] arreglo, int valor1, int valor2) where T : IComparable<T>
        {
            bool result = false;

            if (Convert.ToInt32(arreglo[valor1]) > Convert.ToInt32(arreglo[valor2]))
                result = true;

            return result;
        }


        /// <summary>
        /// Metodo Imprimir implementado como extension
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arreglo a imprimir</param>
        public static void Imprimir<T>(this T[] arreglo) where T : IComparable<T>
        {
            Console.WriteLine();

            foreach (var item in arreglo)
                Console.Write($"{item} ");

            Console.WriteLine();
        }

        public static void ImprimirEnL<T>(this T[] arreglo) where T : IComparable<T>
        {
            foreach (var item in arreglo)
                Console.Write($"{item} ");
        }

    }
}
