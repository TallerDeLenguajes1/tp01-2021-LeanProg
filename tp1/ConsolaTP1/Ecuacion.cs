using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTP1
{
    class Ecuacion
    {
        private int numerouno;
        private int numerodos;

        public Ecuacion(int numerouno, int numerodos)
        {
            this.Numerouno = numerouno;
            this.Numerodos = numerodos;
        }

        public int Numerouno { get => numerouno; set => numerouno = value; }
        public int Numerodos { get => numerodos; set => numerodos = value; }


        public static int Suma(Ecuacion miEcuacion)
        {
            int suma = miEcuacion.numerouno + miEcuacion.Numerodos;

            return suma;
        }
        public static int Division(Ecuacion miEcuacion)
        {
            int division;
            try
            {
                division = miEcuacion.numerouno / miEcuacion.numerodos;
             
            }
            catch(Exception ex)
            {
                string error = ex.Message;
                Console.Write("Error: "+ error);
                return 002;
            }
            return division;
        }
        public static void Cuadrado(Ecuacion numeros)
        {
            int potencia2 = numeros.Numerodos * numeros.Numerodos;
            Console.WriteLine("Cuadrado del numero 2: "+ potencia2);
            potencia2 = numeros.numerouno * numeros.numerouno;
            Console.WriteLine("Cuadrado del numero 1: " + potencia2);

        }
    }
}
