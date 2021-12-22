using System;
using System.Threading.Tasks;

namespace CShp_Task_e_Await
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Sincrono();
        //}

        static void Sincrono()
        {
            Console.WriteLine("Tecle algo para iniciar ...\n");
            Console.ReadLine();
            SincronoAguarde(5);
            Console.WriteLine("Já passou 5 segundos ...\n");
            Console.WriteLine("Fim");
            Console.ReadLine();
        }


        static void SincronoAguarde(int tempo)
        {
            Console.WriteLine("Sincrono - Iniciando espera ...");
            Task.Delay(TimeSpan.FromSeconds(tempo));
            Console.WriteLine("Sincrono - Fim da espera ...");
        }

        static async Task Main(string[] args)
        {
            await AsyncAwait();
        }

        static async Task AsyncAwait()
        {
            Console.WriteLine("Tecle algo para iniciar ...\n");
            Console.ReadLine();
            await AsyncAwaitAguarde(5);
            Console.WriteLine("Já passou 5 segundos ...\n");
            Console.WriteLine("Fim");
            Console.ReadLine();
        }

        static async Task AsyncAwaitAguarde(int tempo)
        {
            Console.WriteLine("AsyncAwait - Iniciando espera ...");
            await Task.Delay(TimeSpan.FromSeconds(tempo));
            Console.WriteLine("AsyncAwait - Fim da espera ...");
        }
    }
}
