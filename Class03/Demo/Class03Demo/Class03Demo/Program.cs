using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Class03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string path = "../../../myFile.txt";
            //  FileWriteAllText(path);
            //FileReadAllText(path);
            //  ReadAllLinesFromText(path);
            // AppendToFile(path);
            //CreateFile();
            // ReadFile(path);
            // DeleteAFile(path);

            PracticeUsingSplit();
        }

        static void FileWriteAllText(string path)
        {
            //set our contents to get written
            string myInfo = "DotNet Rocks!";

            //Actual act of writing to the File
            File.WriteAllText(path, myInfo);
        }

        static void FileReadAllText(string path)
        {
            string result = File.ReadAllText(path);
            Console.WriteLine(result);
        }

        static void ReadAllLinesFromText(string path)
        {
            string[] content = File.ReadAllLines(path);

            Console.WriteLine(String.Join('\n', content));
        }

        static void AppendToFile(string path)
        {
            string[] words =
            {
               "What happens if i",
               "don't add a new line",
               "at the end ofa sentance"
            };

            File.AppendAllLines(path, words);
        }

        static void CreateFile()
        {
            string path = "newFile.txt";
            string[] words = { "I", "Love", "Coffee" };

            try
            {
                using (StreamWriter sw = new StreamWriter(path) )
                {
                    try
                    {
                        sw.Write(String.Join('\n', words));
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        sw.Close();
                    }
                 
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
            }
        }

        // require teh file to already exist
        static void ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
            }
        }

        static void DeleteAFile(string path)
        {
            File.Delete(path);
        }

        static void PracticeUsingSplit()
        {
            char[] delimiterChars = { ' ', ',', '.', ':','-', '\t' };

            string text = "one\ttwo three:four,five-six seven";

            string[] words = text.Split(delimiterChars);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
