namespace Comptador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio Variables
            int comptador = 1; //primer mirar que s'inicialitza

            //Operacions
            while (comptador < 10) //segona mirar que es compleixi la condició
            {
                Console.WriteLine("Valor comptador "+comptador);
                comptador++; //actualitzar el comptador                              
            }

        }
    }
}
