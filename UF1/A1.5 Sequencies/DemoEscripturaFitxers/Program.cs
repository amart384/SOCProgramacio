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

            //Fer un programa que vagi llegint lines de consola
            //i que les escrigui en un fitxer.
            //fins que l'introduim la linia amb el contingut "FI"

            using System.Globalization; // Importa la funcionalidad para gestionar configuraciones regionales (cultura).

namespace DemoEscripturaFitxers
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // Configura la consola para leer y escribir correctamente caracteres especiales (ç, ñ, acentos, etc.)
                Console.InputEncoding = System.Text.Encoding.UTF8;
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // Configura la cultura invariable para evitar problemas con decimales y separadores según la región.
                CultureInfo culture = CultureInfo.InvariantCulture;
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;

                // Declara variables para el StreamWriter (archivo), la línea leída y el control de salida.
                StreamWriter fitxer;
                String linia;
                bool sortir = false;

                // Inicializa el StreamWriter para escribir en el archivo dades.txt
                // en modo añadir (append).
                fitxer = new StreamWriter(@".\..\..\..\dades.txt", true);

                // Bucle que se repite hasta que el usuario escriba "FI".
                while (!sortir)
                {
                    linia = Console.ReadLine(); // Lee una línea de la consola.
                    if (linia == "FI") // Si la línea es "FI", se sale del bucle.
                    {
                        sortir = true;
                    }
                    else
                    {
                        fitxer.WriteLine(linia); // Escribe la línea en el archivo.
                    }
                }
                fitxer.Close(); // Cierra el archivo para guardar los cambios.
                
            }
        }
    }

}
    }
}

  
 
