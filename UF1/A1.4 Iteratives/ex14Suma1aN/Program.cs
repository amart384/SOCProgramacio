using System.Runtime.ConstrainedExecution;

namespace ex14Suma1aN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fer un programa que demani un número N i calculi la suma del 1 al N. Per
            //exemple si donem el 4 ha de calcular 1 + 2 + 3 + 4 = 10
            int i,N;
            int sumaacumulada = 0;

            Console.WriteLine("Introdueix un número N: ");
            N = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= N)
            {
                sumaacumulada = sumaacumulada + i;

                i++;
            }

            Console.WriteLine("La suma acumulada és: " + sumaacumulada);

        }
    }
}
