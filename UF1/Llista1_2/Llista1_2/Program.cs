namespace Llista1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lletra_int; //16 bits 
            char lletra_char; //32bits
            double lletra_double; //64 bits
            int majuscules_int;
            char majuscules_char;

            //Console.WriteLine("Entra una lletra:");
            //lletra_char = Convert.ToInt32(Console.ReadLine()); //ERROR
            //Console.WriteLine("lletra_char  " + lletra_char);

            //Exercici 5. No funciona
            Console.WriteLine("Entra una lletra:");
            lletra_char = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("lletra_char  "+lletra_char); //mostra a

            //Exercici 5. Sí funciona
            Console.WriteLine("Entra una lletra:");
            lletra_int = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("lletra_char  "+ lletra_int); //mostra 97

            //Exercici 6
            Console.WriteLine("Entra una lletra:");
            lletra_int = Convert.ToChar(Console.ReadLine());
            //passa a majuscula
            majuscules_int = lletra_int - 32;
            Console.WriteLine($"majuscules {majuscules_int}");
            //conversio a caracter
            majuscules_char = Convert.ToChar(majuscules_int);
            Console.WriteLine($"majuscules {majuscules_char}");

            //Exercici 6
            Console.WriteLine("Entra una lletra:");
            string letra = Console.ReadLine();
            string letra_mayuscula = letra.ToUpper();
            Console.WriteLine(letra_mayuscula);






            //Console.WriteLine("Entra una lletra:");
            //lletra_int = Convert.ToChar(Console.ReadLine());

            // Console.WriteLine($"lletra_int {lletra_int}");




            //lletra_double = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"lletra_int {lletra_int}");
            //Console.WriteLine($"lletra_char {lletra_char}");

            //majuscules = lletra_char - 32;






        }
    }
}
