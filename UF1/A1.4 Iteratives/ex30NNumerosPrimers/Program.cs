namespace ex30NNumerosPrimers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int comptador_numeros_primer = 0;
            int M = 1;
            int divisor = 1;
            int divisors = 0;

            Console.Write("Introdueix un número N: ");
            N = int.Parse(Console.ReadLine());

            while (comptador_numeros_primer < N){
                divisor = 1;
                divisors = 0;

                for (divisor=1; divisor<=M; divisor++){
                    if (M % divisor == 0){
                        divisors++;
                    }
                }
                
                if ((divisors == 2)||(M==1)){
                    Console.Write(M + " ");
                    comptador_numeros_primer++;
                }

                M++;
            }
        }
    }
}
