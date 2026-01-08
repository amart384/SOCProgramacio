namespace SouCanviFeina
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Double Hores, Import, SouNet, Sou, QuatitatIRPF, IRPF;

            Console.WriteLine("Import:");
            Import = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hores:");
            Hores = Convert.ToDouble(Console.ReadLine());

            Sou = Import * Hores;
            IRPF = 21.0;

            QuatitatIRPF = Sou * (IRPF / 100.0);

            SouNet = Sou - QuatitatIRPF;

            Console.WriteLine("El teu sou net és:" + SouNet);

            if (SouNet < 2000) Console.WriteLine("Em busco una altre feina");


            if (SouNet >= 2000) Console.WriteLine("Em quedo a la mateixa feina");

            if (SouNet < 2000) Console.WriteLine("Em busco una altre feina");
            else Console.WriteLine("Em quedo a la mateixa feina");


            if (SouNet >= 2000) Console.WriteLine("Em quedo a la mateixa feina");
            else Console.WriteLine("Em busco una altre feina");


            if (SouNet > 6000) Console.WriteLine("Treballaré a mitja jornada");
        }
    }
}
