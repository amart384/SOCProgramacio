namespace ex03DemanarSortir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3. Programa que validi una resposta s/n amb while.
            //Que demani una resposta s ó n,
            //i si no és s ó n que la torni a demanar, i si no està

            //declaració de variables
            char resposta = 'n';

            while (resposta != 's')
            {
                Console.WriteLine("Vols sortir? (s/n): ");
                resposta = Console.ReadKey(true).KeyChar;
            }

            /* string resposta;

            Console.Write("Vols sortir? (s/n): ");
            resposta = Console.ReadLine();

            while (resposta != "s")
            {
                Console.Write("Vols sortir? (s/n): ");
                resposta = Console.ReadLine();
            }   
            
            Millores
              Console.Write("Vols sortir? (s/n): ");
            resposta = Console.ReadLine().ToLower();

            while (resposta != "s")
            {
                Console.Write("Vols sortir? (s/n): ");
                resposta = Console.ReadLine().ToLower();
            }

            //Utilitzant Console.ReadKey()
            char resposta;

            Console.Write("Vols sortir? (s/n): ");
            resposta = Console.ReadKey(true).KeyChar;

            while (resposta != 's' && resposta != 'n')
            {
                 Console.Write("Vols sortir? (s/n): ");
                resposta = Console.ReadKey(true).KeyChar;
            }


             */
        }
    }
}
