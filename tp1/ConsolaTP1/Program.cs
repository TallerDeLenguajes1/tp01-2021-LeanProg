using System;

namespace ConsolaTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numero1, numero2;
            Console.WriteLine("Ingrese dos numeros para sumar y dividir ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            Ecuacion misNumeros = new Ecuacion(numero1,numero2);
            int suma = Ecuacion.Suma(misNumeros);
            int division = Ecuacion.Division(misNumeros);
            Console.WriteLine("Resultado de la suman: "+suma);
            if (division == 002) { Console.WriteLine("Nose puede dividir por cero intentelo de nuevo"); }
            else { Console.WriteLine("resultado de la division: " + division); }
            Ecuacion.Cuadrado(misNumeros);

        }
    }
}
