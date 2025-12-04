using System.Media;
using System.Numerics;
using WMPLib;

namespace ex02_Xat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            /*Habilitar WindowsMediaPlayer :               
            En el Explorador de soluciones, 
            nos ponemos encima del proyecto
            clic derecho en References
            Selecciona Add Reference…
            Ve a la pestaña COM
            Busca Windows Media Player*/
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            //l'arxiu mp3 ha d'estar guardar en la subcarpeta que el projecte \bin\Debug
            string rutaMp3 = @"tu-vuo-fa-l-americano.mp3";
            player.URL = rutaMp3;

            while (true)
            {
                Console.WriteLine("Hola, en què et puc ajudar?");
                text = Console.ReadLine();

                if (text.Contains("poema")) 
                {
                    Console.WriteLine("Aquí tens un poema:");
                    Console.WriteLine("Estiu,sabem que arribes, volem veure’t, ho saben les onades que també vindran a rebre’t.");
                }

                if ( (text.Contains("música")) || (text.Contains("cançó")) )
                {
                    // Reproduïr MP3
                    Console.WriteLine("Reproduint MP3...");
                    player.controls.play();
                }
            }

                //??? fer els controls de pausa
                if (text.Contains("pausa"))
                {
                    player.controls.pause();
                }

                //??? fer els controls de stop
                if (text.Contains("stop"))
                {
                    player.controls.stop();
                }

                if (text.Contains("continuar"))
                {
                    player.controls.play();
                }

                if (text.Contains("sortir"))
                {
                    Environment.Exit(0);
                }

                if ((text.Contains("sortir")) || (text.Contains("adéu")))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
