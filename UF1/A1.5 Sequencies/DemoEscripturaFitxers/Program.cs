using System.Globalization;

namespace DemoEscripturaFitxers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configurem la consola per lelgir i escriure corretament
            //els caracters ç, ñ, accents, etc.
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Configurar (per evitar problemes amb els decimals)
            //dels . i les , en funció de la configuració regional de l'ordinador
            CultureInfo culture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;


            //Fer un programa que llegeixi una lina de la consola i l'escrigui en un fitxer.

            //Declarar les variable per escriure al fitxer
            StreamWriter fitxer;
            String linia;

            //Obrir el fitxer per escriure
            fitxer = new StreamWriter(@".\..\..\..\dades.txt");

            //Operar amb el fitxer
            linia = Console.ReadLine(); //llegir una linia de la consola
            fitxer.WriteLine(linia); //escriure la linia al fitxer

            //Tancar el fitxer
            fitxer.Close();


        }
    }
}

  
 
