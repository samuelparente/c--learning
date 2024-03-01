//Samuel Parente - C# programming exercises

using System;

namespace ReadWriteFile
{
    internal class ReadWriteFile
    {
        static void Main(string[] args)
        {
            string myName = "SAMUEL PARENTE";
            string readText = "";

            Console.WriteLine("Write 'SAMUEL PARENTE' to a file and then read it");

            //Write to file
            try
            {
                File.WriteAllText("myFile.txt", myName);
            }
            catch (Exception e) { }
            {
                Console.WriteLine("An unexpected error ocurred when writing to file.");
            }

            //Read from file
            try
            {
                readText = File.ReadAllText("myFile.txt");
                Console.WriteLine(readText);
            }
            catch (Exception e) { }
            {
                Console.WriteLine("An unexpected error ocurred when reading the file.");
            }
 
        }
    }
}
