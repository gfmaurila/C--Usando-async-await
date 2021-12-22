using System;
using System.Threading.Tasks;

namespace ValueTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = CalculaSoma(0, 0).Result;
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static async ValueTask<int> CalculaSoma(int a, int b)
        {
            if(a == 0 && b == 0)
            {
                return 0;
            }

            return await Task.Run(() => a + b);
        }
    }
}
