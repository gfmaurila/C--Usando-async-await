using System;
using System.Threading.Tasks;

namespace CShp_ValueTask_e_ValueTask_T
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await MetodoSemRetornoDeValor();
            Console.WriteLine("A Tarefa foi concluida!");

            var result = await MetodoRetorndoValor();
            Console.WriteLine($"Valor retornado {result}");
        }

        static async ValueTask MetodoSemRetornoDeValor()
        {
            Console.WriteLine("MetodoSemRetornoDeValor");
            await Task.Delay(2000);
        }

        static async ValueTask<int> MetodoRetorndoValor()
        {
            Console.WriteLine("MetodoRetorndoValor");
            await Task.Delay(2000);
            return 2022;
        }

    }
}
