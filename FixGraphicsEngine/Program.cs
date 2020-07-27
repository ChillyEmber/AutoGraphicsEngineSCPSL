using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Diagnostics;

namespace FixGraphicsEngine
{
    class Program
    {
        static void Main()
        {
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SCP Secret Laboratory/registry.txt");
            string text = File.ReadAllText(fileName);
            if(text.Contains("07graphics_api::-%(|::0"))
            {
                AlreadyAuto();
            }
            if(text.Contains("07graphics_api::-%(|::1"))
            {
                text = text.Replace("07graphics_api::-%(|::1", "07graphics_api::-%(|::0");
                File.WriteAllText(fileName, text);
                Barf();
            }
            if(text.Contains("07graphics_api::-%(|::2"))
            {
                text = text.Replace("07graphics_api::-%(|::2", "07graphics_api::-%(|::0");
                File.WriteAllText(fileName, text);
                Barf();
            }
            if(text.Contains("07graphics_api::-%(|::3"))
            {
                text = text.Replace("07graphics_api::-%(|::3", "07graphics_api::-%(|::0");
                File.WriteAllText(fileName, text);
                Barf();
            }
            if (text.Contains("07graphics_api::-%(|::4"))
            {
                text = text.Replace("07graphics_api::-%(|::4", "07graphics_api::-%(|::0");
                File.WriteAllText(fileName, text);
                Barf();
            }
            else
            {
                text = text.Replace("07graphics_api::-%(|::", "07graphics_api::-%(|::0");
            }
            File.WriteAllText(fileName, text);
            Barf();
        }

        static void Barf()
        {
            Console.WriteLine("Done! Hit any key to quit!");
            Console.ReadKey();
            Process.GetCurrentProcess().Kill();
        }
        static void AlreadyAuto()
        {
            Console.WriteLine("Your Graphics API is already set to auto.");
            Console.WriteLine("Press any key to quit!");
            Console.ReadKey();
            Process.GetCurrentProcess().Kill();
        }
    }
}
