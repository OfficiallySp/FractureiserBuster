using System;
using System.IO;
using Microsoft.Win32;

class Program
{
    static void Main()
    {
        string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string edgePath = Path.Combine(localAppData, "Microsoft Edge");

        string[] badPaths = new string[]
        {
            Path.Combine(edgePath, ".ref"),
            Path.Combine(edgePath, "client.jar"),
            Path.Combine(edgePath, "lib.dll"),
            Path.Combine(edgePath, "libWebGL64.jar"),
            Path.Combine(edgePath, "run.bat"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "run.bat")
        };

        string badRegistryKey = @"Software\Microsoft\Windows\CurrentVersion\Run\t";

        bool res = false;
        Console.WriteLine("Beginning File Search");
        foreach (string path in badPaths)
        {
            Console.WriteLine($"Searching in... {path}");
            if (File.Exists(path))
            {
                Console.WriteLine("Malware Detected! Attempting Removal Of {0}...", path);
                File.Delete(path);
                res = true;
            }
        }

        // Check for the bad registry key
        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(badRegistryKey))
        {
            Console.WriteLine("Looking for further anomolies in the registry");
            Console.WriteLine($"Searching in... {badRegistryKey}");
            if (key != null)
            {
                Console.WriteLine("Bad registry key found! Removing {0}...", badRegistryKey);
                Registry.CurrentUser.DeleteSubKey(badRegistryKey);
                res = true;
            }
        }

        if (!res)
        {
            Console.WriteLine("Nothing found! :)");
        }
        else
        {
            Console.WriteLine("It is probably a good idea to change ALL passwords ASAP");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}