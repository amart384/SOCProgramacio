using WMPLib;

namespace ex02_Xat_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaració de variables
            string text;
            bool sortir = false;

            /*Habilitar WindowsMediaPlayer :               
            En el Explorador de soluciones, 
            nos ponemos encima del proyecto
            clic derecho en References
            Selecciona Add Reference…
            Ve a la pestaña COM
            Busca Windows Media Player*/
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            while (!sortir)
            {
                Console.WriteLine("Hola, en què et puc ajudar?");
                text = Console.ReadLine();

                //Operacions
                if (text.Contains("poema"))
                {
                    //Sortida del resultat
                    Console.WriteLine("Aquí tens un poema:");
                    Console.WriteLine("Estiu,sabem que arribes, volem veure’t, ho saben les onades que també vindran a rebre’t.");
                }                
                else if ((text.Contains("música")) || (text.Contains("cançó")))
                {
                    // Reproduïr MP3
                    //l'arxiu mp3 ha d'estar guardar en la subcarpeta que el projecte \bin\Debug\net     
                    player.URL = @"tu-vuo-fa-l-americano.mp3"; // ruta del fitxer MP3;
                    Console.WriteLine("Reproduint MP3...");
                    player.controls.play();

                    //Console.ReadLine(); //Simula una pausa, fins polsar una tecla                  
                }
                //???? afegir els condicionals per
                //pausar la reproducció
                //para la reproducció
                //reprendre la reproducció
                else if(text.Contains("pausa"))
                {
                    player.controls.pause();
                }
                else if(text.Contains("stop"))
                {
                    player.controls.stop();
                }
                else if(text.Contains("reprendre"))
                {
                    player.controls.play();
                }                //Si s'escriu sortir s'acaba el programa

                else if(text.Contains("sortir"))
                {
                    sortir = true;
                }
                //????Modificar el if anterior tant si s'escriu sortir o adéu
            }
          
        }
    }
}
