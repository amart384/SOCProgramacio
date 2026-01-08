namespace ComptadorDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio Variables
            int comptador = 1;

            //Operacions            
            do {
                Console.WriteLine("Valor comptador" + comptador);
                comptador++;
            } while (comptador < 10);

            /*Error
            {
               Console.WriteLine("Valor comptador" + comptador);
               comptador++;
            } while (comptador < 10);             
            */
        }
    }
}
