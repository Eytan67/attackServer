using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace attackServar
{
    public static class temporary
    {
        public static async Task GetData()
        {
            string path = @"C:\Users\user\source\repos\attackServar\TextFile1.txt";
            string text = "";
            if (File.Exists(path))
            {
                await Task.Run( () => { text = File.ReadAllText(path); });

            }
            Console.WriteLine(text);
        }
        public static async Task<string> GetDataFromServisAAsync()
        {

            await Task.Delay(1000);
            return "data from servis a";
        }

        public static async Task<string> GetDataFromServisBAsync()
        {

            await Task.Delay(2000);
            return "data from servis b";
        }
    }
}
