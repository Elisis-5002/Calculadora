using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Clases
{
    internal class Ordenamientos
    {
        int[] arreglo;
        public int [] Burbuja(int[] arreglo) {
            try
            {
                this.arreglo = arreglo;
                int aux;
                for (int i = 0; i < arreglo.Length - 1; i++)
                {
                    for (int j = i+1; j < arreglo.Length; j++)
                    {
                        if(arreglo[i] > arreglo[j])
                        {
                            aux = arreglo[i]; 
                            arreglo[i] = arreglo[j];
                            arreglo[j] = aux; 
                        }

                    }
                }
                return arreglo; 

            }
            catch (Exception ex)
            {
                throw;
                return null;
            }
        }
    }
}
