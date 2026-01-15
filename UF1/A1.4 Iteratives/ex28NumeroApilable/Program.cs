using System.Runtime.ConstrainedExecution;

namespace ex28NumeroApilable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fer un programa que digui si un número és apilable.
            //Un número és apilable si es pot escriure com la suma dels primers k números naturals per a algun k.
            //Ho són el 0, 1, 3, 6, 10, 15, 21, ..

            int N, i = 0, sumaacumulada = 0;
            bool numero_passat = false;
            bool numero_trobat = false;
            Console.WriteLine("Introdueix un número N: ");
            N = Convert.ToInt32(Console.ReadLine());            

            //Opció A
            while (sumaacumulada < N)
            {
                i++;
                sumaacumulada = sumaacumulada + i;  
            }

            if (sumaacumulada == N){
               Console.WriteLine("El número " + N + " és apilable.");
            }else
            {
                Console.WriteLine("El número " + N + " no és apilable.");
            }

            //Opció B
            while ((!numero_passat) && (!numero_trobat))
            {
                i++;
                sumaacumulada = sumaacumulada + i;
               
                if (sumaacumulada == N) numero_trobat = true;
                if (sumaacumulada > N) numero_passat = true;
            } 

            if (numero_trobat){
                Console.WriteLine("El número " + N + " és apilable.");
            }
            else{
                Console.WriteLine("El número " + N + " no és apilable.");
            }

        }
    }
}
