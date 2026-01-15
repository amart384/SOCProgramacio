namespace ex27LlencarMonedes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Fer un programa que generi aleatòriament 
            // i digui quin % de cares i creus ha tret            

            // Fer un programa que llanci 1000000 de monedes (s’inventi 0-cara o 1-creu)
            // i digui quin % de cares i creus ha tret           

            //Declaració de variables
            double percentatge_cares = 0;
            double percentatge_creus = 0;
            double num_cares = 0;
            double num_creus = 0;
            int moneda = 0; //0 = cara, 1 = creu
      
            //Per poder generar números aleatoris
            Random rnd = new Random();

            for (int i=1; i<=1000000; i++) { 
                //Llençar una moneda
                //genera un numero "Enter" entre 0 i 2, sense incloure el 2
                //genera un numero 0 o 1
                moneda = rnd.Next(0, 2);
                //nota
                //genera un numero "Double" entre 0 i 2, sense incloure el 2
                //pot generar qualsevol numero entre 0 i 2, per exemple 0.34567, 1.9999, etc
                //moneda = rnd.NextDouble(0, 2);

                if (moneda == 0) num_cares ++;
                else num_creus ++;
            }

            percentatge_cares = (num_cares * 100.0) / 1000000.0;
            percentatge_creus = (num_creus * 100.0) / 1000000.0;

            //Sortida
            Console.WriteLine("el % de cares és:"+ percentatge_cares);
            Console.WriteLine("el % de creus és:" + percentatge_creus);
        }
    }
}



















/*
   int moneda = 0; //0 = cara, 1 = creu

 Random rnd = new Random();
 moneda = rnd.Next(0, 2);

 if (moneda==0)
 {
     Console.WriteLine("Ha sortit cara");
 }
 else
 {
     Console.WriteLine("Ha sortit creu");
 }
 
 
 
 //---------------------------------
			//Declaració de variables
            double vegades_cara = 0;
            double vegades_creu = 0;

            int moneda = 0; //0 = cara, 1 = creu

            //Inicialització de l'objecte Random per poder generar números aleatoris
            Random rnd = new Random();

            //Processament
            for (int i=0; i<100; i++)
            {
                //Genera un número aleatori enter entre 0 i 1, o sigui 0 o 1
                //No confondre amb rnd.NextDouble(); que genera un número entre 0 i 1, per exemple 0.34567, 0.9999. Mai generarà el 1
                moneda = rnd.Next(0, 2);

                Console.WriteLine("Surt la moneda " + moneda);
				
				 if (moneda==0)
				 {
					vegades_cara++;
				 }
				 else
				 {
					vegades_creu++;
				 }

            }

            //Càlcul percentatges
			percentatge_cares =  (vegades_cara / 1000000.0)*100.0
			percentatge_creus =  (vegades_creu / 1000000.0)*100.0


            //Sortida
            Console.WriteLine("El % de cares és:"+percentatge_cares);
            Console.WriteLine("El % de creus és:"+percentatge_creus);
*/

