using System;
using System.IO;

namespace FileInfo_hw9
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("NonExistingDir")) Directory.Delete("NonExistingDir", true);
            
            FileInfo file = new FileInfo("./NonExistingDir/nonExistingFile.txt");
            try
            {
                Console.WriteLine("Trying to create file in non-existing dir...");
                file.Create();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"Failure: {e.Message}\nCreating Directory...");
                Directory.CreateDirectory("NonExistingDir");
                Console.WriteLine("Creating file in new dir...");
                file.Create();
            }

            if (file.Exists) Console.WriteLine("File successfully created...");
            
        }
    }
}
