
using System.Globalization;

namespace DemoLecturaFitxers
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Declarar les variables
            StreamReader fitxer;
            String linia;

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //per carregar el format de cultura invariant (per evitar problemes amb els decimals)
            // dels . i les , en funció de la configuració regional de l'ordinador
            CultureInfo culture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;


            /*
            //EXEMPLE1
            //Programa per llegir el contingut d'un fitxer de text
            //i comprova si una linia conte la paraula "TARDA"

            //Obrir el fitxer
            fitxer = new StreamReader(@".\..\..\..\dades.txt");

            //Tractar/llegir el fitxer
            while (!fitxer.EndOfStream) //no sigui final de fitxer
            {
                linia = fitxer.ReadLine(); //llegir una linia del fitxer
                if (linia == "TARDA"){
                    Console.WriteLine("El fitxer conté la paraula TARDA");
                }
                //Console.WriteLine(linia); //mostrar la linia llegida
            }            
            //Tancar el fitxer
            fitxer.Close();*/

            //EXEMPLE2
            //Programa per llegir el contingut d'un fitxer de text
            //que mostri un missatge per pantalla que diu
            //si conte la paraula "TARDA" o no la conte
            //Obrir el fitxer
            fitxer = new StreamReader(@".\..\..\..\dades.txt");
            bool conteparaula = false;

            //Tractar/llegir el fitxer
            while (!fitxer.EndOfStream)//no sigui final de fitxer
            {
                linia = fitxer.ReadLine(); //llegir una linia del fitxer
                if (linia == "TARDA") {
                    conteparaula = true;
                }                
            }
          
            if (conteparaula)
            {
                Console.WriteLine("El fitxer conté la paraula TARDA");
            }
            else
            {
                Console.WriteLine("El fitxer no conté la paraula TARDA");
            }
            //Tancar el fitxer
            fitxer.Close();
            
            //EXEMPLE3
            //Programa per llegir el contingut d'un fitxer de text
            //que mostra un missatge per pantalla que digui
            //si quantes vegades conte la paraula "HOLA"

            int comptador = 0;
            //Obrir el fitxer
            fitxer = new StreamReader(@".\..\..\..\dades.txt");        

            //Tractar/llegir el fitxer
            while (!fitxer.EndOfStream) //no sigui final de fitxer
            {
                linia = fitxer.ReadLine(); //llegir una linia del fitxer
                if (linia == "HOLA")
                {
                    comptador++;
                }
            }

            //Tancar el fitxer
            fitxer.Close();

            Console.WriteLine("La paraula HOLA apareix "+comptador+" vegades");












            /*
            //Exemple1
            //Programa per llegir d'un fitxer de text
            //linia a linea
            //i mostrar per consola el seu linia

            StreamReader fitxer; //Classe que representa un fitxer
            String linia; // Variable on guardarem cada linia llegida

            //Obrim el fitxer
            fitxer = new StreamReader(@".\..\..\..\dades.txt");
            while (!fitxer.EndOfStream)
            {
                //Llegim linia a línia fins arribar al final del fitxer
                linia = fitxer.ReadLine(); // Igual que quan llegim per consola (un string)
                Console.WriteLine($"{linia}"); // Mostrem el que hem llegit
            }
            fitxer.Close(); // Sempre tanquem el fitxer


            //Exemple2
            //Programa per llegir d'un fitxer de text
            //linia a linea
            //i mostrar per consola el seu linia
            //convertient cada linia a enter
            int numero;
            //Obrim el fitxer
            fitxer = new StreamReader(@".\..\..\..\dades2.txt");
            while (!fitxer.EndOfStream)
            {
                //Llegim linia a línia fins arribar al final del fitxer
                numero = Convert.ToInt32(fitxer.ReadLine()); // Igual que quan llegim per consola (un string)
                Console.WriteLine($"{numero}"); // Mostrem el que hem llegit
            }
            fitxer.Close(); // Sempre tanquem el fitxer


            //Exemple3
            //Programa per llegir d'un fitxer de text
            //linia a linea
            //i mostrar per consola el seu linia

            StreamReader fitxer; //Classe que representa un fitxer
            String linia; // Variable on guardarem cada linia llegida

            //Obrim el fitxer
            fitxer = new StreamReader(@".\..\..\..\dades.txt");
            while (!fitxer.EndOfStream)
            {
                //Llegim linia a línia fins arribar al final del fitxer
                linia = fitxer.ReadLine(); // Igual que quan llegim per consola (un string)
                if (linia=="TARDA") Console.WriteLine("el fitxer conte la paraula tarda");
            }
            fitxer.Close(); // Sempre tanquem el fitxer


            //Exemple4
            //Programa per llegir d'un fitxer de text
            // caracter a caracter
            //i mostrar per consola el seu linia
            StreamReader fitxer2; //Classe que representa un fitxer
            char caracter; // Variable on guardarem cada linia llegida

            //Obrim el fitxer
            fitxer2 = new StreamReader(@".\..\..\..\prova.txt");
            while (!fitxer2.EndOfStream)
            {
                //Llegim linia a línia fins arribar al final del fitxer
                caracter = (char)fitxer2.Read(); // Igual que quan llegim per consola (un string)
                Console.WriteLine($"{caracter}"); // Mostrem el que hem llegit
            }
            fitxer2.Close(); // Sempre tanquem el fitxer
            */



        }
    }
}
