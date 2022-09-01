using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionArchivo.TXT
{
    public class Operaciones
    {
        public static void DoOperation()
        {
            try
            {
                int resultado = 0, sumaTotal = 0, indice;

                string nombresLine = System.IO.File.ReadAllText(@"C:\Users\digis\OneDrive\Documents\AndresFerrerServin\Carga masiva\nombres.txt");


                var nombresArray = nombresLine.Split(",");

                Array.Sort(nombresArray, StringComparer.InvariantCulture);

                foreach (string nombre in nombresArray)
                {
                    string nuevoNombre = nombre.Replace("\"", "");
                    byte[] asciiValores = Encoding.ASCII.GetBytes(nuevoNombre);

                    resultado = 0;
                    indice = Array.IndexOf(nombresArray, nombre) + 1;


                    foreach (int valor in asciiValores)
                    {
                        resultado = resultado + (valor - 64);

                    }
                    resultado = resultado * indice;

                    sumaTotal += resultado;
                }

                Console.WriteLine("La suma total es: " + sumaTotal);
            }
            catch (Exception)
            {

                throw;  
            }
        }
    }
}
