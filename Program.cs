using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServar
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await temporary.GetData();
            //Console.WriteLine("Recive data!");
            //Console.ReadLine();

            Task<string> taskA = temporary.GetDataFromServisAAsync();
            Task<string> taskB = temporary.GetDataFromServisBAsync();

            await Task.WhenAll(taskA, taskB);
            Console.WriteLine(taskA.Result);
            Console.WriteLine(taskB.Result);

            Console.ReadLine();

        }


    }
}
