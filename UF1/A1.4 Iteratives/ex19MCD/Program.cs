namespace ex19MCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fer un programa que calculi el màxim comú divisor de dos números. El màxim
            //comú divisor és el divisor de tots dos més gran que hi hagi.Si no trobem cap
            //divisor, el 1 sempre ho serè.
            int num1;
            int num2;
            Boolean trobat = false;
            Console.WriteLine("Introdueix primer nombre:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix segon nombre:");
            num2 = Convert.ToInt32(Console.ReadLine());

            int divisor = Math.Min(num1, num2);

            while (!trobat)
            {
                if (num1 % divisor == 0 && num2 % divisor == 0)
                {
                    trobat = true;
                }
                else
                {
                    divisor--;
                }
            }
            Console.WriteLine("El màxim comú divisor de " + num1 + " i " + num2 + " és: " + divisor);

        }
    }
}
