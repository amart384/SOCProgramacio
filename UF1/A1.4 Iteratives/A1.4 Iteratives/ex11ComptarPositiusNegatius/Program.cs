namespace ex11ComptarPositiusNegatius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demanar 10 enters i dir quants eren positius,
            //quants negatius i quantes vegades
            //hi havia el zero
            int positius = 0;
            int negatius = 0;
            int zeros = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Introdueix un nombre enter: ");
                int nombre = Convert.ToInt32(Console.ReadLine());

                if (nombre > 0)
                    positius++;
                else if (nombre < 0)
                    negatius++;
                else
                    zeros++;
            }

            Console.WriteLine("\nResultats:");
            Console.WriteLine("Positius: " + positius);
            Console.WriteLine("Negatius: " + negatius);
            Console.WriteLine("Zeros: " + zeros);
        }
    }
}
