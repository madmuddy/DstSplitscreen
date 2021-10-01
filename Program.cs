using System.Diagnostics;
using System.IO;
using System.Threading;

namespace DSTSplitScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("UniversalSplitScreen.exe");

            Thread.Sleep(10000);

            string confPath = Path.Combine(Directory.GetCurrentDirectory(), @"steam_settings\settings");

            using (StreamWriter sw = new StreamWriter(confPath + @"\user_steam_id.txt"))
            {
                sw.Write("76561199582812500");
                sw.Close();
            }

            Process.Start("dontstarve_steam.exe");

            Thread.Sleep(20000);

            using (StreamWriter sw = new StreamWriter(confPath + @"\user_steam_id.txt"))
            {
                sw.Write("76561199582812501");
                sw.Close();
            }

            Process.Start("dontstarve_steam.exe");
        }
    }
}
