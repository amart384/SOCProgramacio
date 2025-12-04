
using WMPLib;

namespace Xat
{
    internal class ProgramS
    {
        static void Main(string[] args)
        {
            //Exemple xat d'un assistent personal
            //-Declaració de variables
            string text;

            //-Entrada de dades
            Console.WriteLine("Hola, en què et puc ajudar?");
            text = Console.ReadLine();

            //-Operacions
            //.Contains comprova si un text està dintre d'una altre text
            //O sigui, comprova si un string està dintre d'una altre string
            //comprova si "poema" està dintre de text
            //Si "poema" està dintre de text,
            //text.Contains("poema") -> es converteix a true
            if (text.Contains("poema"))
            {
                //Sortida del resultat
                Console.WriteLine("Aquí tens un poema:");
                Console.WriteLine("Estiu,sabem que arribes, \n volem veure’t, ho saben les onades que també vindran a rebre’t.");
            }

            //Tant si es posa el text música o cançó ha de sonar el mp3
            if (text.Contains("música"))
            {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                string rutaMp3 = @"tu-vuo-fa-l-americano.mp3";
                player.URL = rutaMp3;
                Console.WriteLine("Reproduint MP3...");
                player.controls.play();

                Console.ReadLine(); //Simula una pausa, fins polsar una tecla                  
            }
        }
    }
}
