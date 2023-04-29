using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4_ejercicioModa
{
    internal class Estadistica
    {
        public static void Moda(String numeros) 
        {
            int i = 0, j = 0, k = 0, cantidadEnteros = 0, repetidos = 0, mayorRep = 0, resultado;
            int valorMinimo = 0, valorMaximo = 0;
            String numero = "", moda = "";
            int[] enteros = null;
            int[,] repeticiones = null;

            foreach(char caracter in numeros) 
            {
                if (caracter == ',' || caracter == '.')
                {
                    resultado = Convert.ToInt16(numero);
                    numero = "";
                    if (i == 0) 
                    {
                        valorMinimo = resultado;
                        valorMaximo = resultado;
                        i++;
                    }

                    if (resultado < valorMinimo) valorMinimo = resultado;
                    else if (resultado > valorMaximo) valorMaximo = resultado;



                    if (caracter != '.') i++;
                    else enteros = new int[i];
                    continue;
                }
                else
                {
                    numero += caracter;
                }
            }

            cantidadEnteros = i;
            i = 0;

            foreach(char caracter in numeros) 
            {
                if (caracter == ',' || caracter == '.')
                {
                    resultado = Convert.ToInt16(numero);
                    numero = "";

                    enteros[i] = resultado;

                    if (caracter != '.') i++;
                    continue;
                }
                else
                {
                    numero += caracter;
                }
            }

            Array.Sort(enteros);

            for (j = 1; j < enteros.Length - 1; j++) 
            {
                if (enteros[j] == enteros[j - 1] && enteros[j] == enteros[j + 1])
                {
                    if (j == enteros.Length - 2) repetidos++;
                }
                else if (enteros[j] != enteros[j - 1] && enteros[j] == enteros[j + 1])
                {
                    if (j == enteros.Length - 2) repetidos++;
                }
                else if (enteros[j] == enteros[j - 1] && enteros[j] != enteros[j + 1])
                {
                    repetidos++;
                }
                else if (enteros[j] != enteros[j - 1] && enteros[j] != enteros[j + 1]) 
                {
                    continue;
                }
            }

            if (repetidos != 0)
            {
                repeticiones = new int[repetidos, 2];

                i = 0;

                for (j = 0; j < enteros.Length - 1; j++)
                {
                    if (enteros[j] == enteros[j + 1]) 
                    {
                        repeticiones[k, i] = enteros[j];
                        repeticiones[k, i + 1] += 1;
                        if (j + 2 != enteros.Length && enteros[j] != enteros[j + 2]) { repeticiones[k, i + 1] += 1; k++; }
                        else if (j + 2 == enteros.Length) { repeticiones[k, i + 1] += 1; }
                    }

                    if(k == repetidos) { break;}
                }

                j = 1;

                for (i = 0; i < repeticiones.GetLength(0); i++)
                { 

                    if (i == 0) mayorRep = repeticiones[i, j];

                    if (repeticiones[i, j] > mayorRep) mayorRep = repeticiones[i, j];
                }


                for (i = 0; i < repeticiones.GetLength(0); i++)
                {
                    if (repeticiones[i, j] == mayorRep && i < repeticiones.GetLength(0) - 1) moda += $"{repeticiones[i, j - 1]}, ";
                    else if (repeticiones[i, j] == mayorRep && i == repeticiones.GetLength(0) - 1) moda += $"{repeticiones[i, j - 1]}.";
                }
            }

            Console.WriteLine($"Cantidad de enteros ingresados fue: {cantidadEnteros}\n");
            Console.WriteLine($"El valor minimo es: {valorMinimo}\n");
            Console.WriteLine($"El valor maximo es: {valorMaximo}\n");
            if(repetidos != 0) Console.WriteLine($"La moda es: {moda}\n");
            else Console.WriteLine("No hay moda\n");
        }
    }
}
