using System;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] arrayTexto = { "hola mundo", "pepe pecas pica papas", "la luna es bonita" };

            string[] resultado = convertToCamelCase(arrayTexto);

            for(int i =0; i<resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }
            */

            /*
            int[][] array = {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };

            int[][] resultado = girar180Grados(array);

            for(int i=0; i<resultado.Length; i++)
            {
                for (int j = 0; j < resultado[i].Length; j++) {
                    Console.Write(resultado[i][j] + " ");
                }
                Console.WriteLine();
            }

            */

            Console.WriteLine(calcularFecha(920));

        }

        static decimal[] MinAndMax(decimal[] array)
        {
            decimal minimo, maximo;
            decimal[] resultado = new decimal[2];

            if (array.Length > 0)
            {
                minimo = array[0];
                maximo = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                    if (minimo > array[i])
                    {
                        minimo = array[i];
                    }

                    if (maximo < array[i])
                    {
                        maximo = array[i];
                    }
                }

                resultado[0] = minimo;
                resultado[1] = maximo;

                return resultado;
            }
            else
            {
                return array;
            }
        }

        static string[] convertToCamelCase(string[] array)
        {
            string palabrasConcatenadas;

            for (int i = 0; i < array.Length; i++)
            {
                string[] arrayPalabras = array[i].Split(" ");
                palabrasConcatenadas = "";

                for (int j = 0; j < arrayPalabras.Length; j++)
                {
                    palabrasConcatenadas = palabrasConcatenadas + char.ToUpper(arrayPalabras[j][0]) + arrayPalabras[j].Substring(1) + " ";
                }

                array[i] = palabrasConcatenadas;
            }

            return array;
        }

        static int[][] girar180Grados(int[][] array)
        {
            int N = array.Length;
            int M = array[0].Length;

            int[][] resultado = new int[M][];

            for(int i=0; i<resultado.Length; i++)
            {
                resultado[i] = new int[N];
            }

            for(int i=0; i<N; i++)
            {

                for(int j=0; j<M; j++)
                {
                    resultado[M - j - 1][i] = array[i][j];
                }
            }

            return resultado;
        }

        static string calcularFecha(int numero) {
            int A =0, M = 0, D =0;
            int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (numero < 0)
                return "";

            if(numero > 365)
            {
                A = numero / 365;
                numero = numero % 365;
            }

            for(int i=0; i<meses.Length; i++)
            {
                if((numero - meses[i]) >= 0)
                {
                    M++;
                    numero = numero - meses[i];
                }
                else
                {
                    break;
                }
            }

            return "Equivale a " + A + " años, " + M + " meses " + numero + " dias";
        }
    }
}
