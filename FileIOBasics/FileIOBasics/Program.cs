using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sorted = from item in values orderby by item select item; //query syntax of linq
            //sorted = values.OrderBy(x=>x);//method syntax of lynq
            ReadFile("");
        }
         static string winDir = System.Environment.GetEnvironmentVariable("windir");

        static void ReadFile(string filePath)
        {
            List<string> textInMemory = new List<string>();
            string path = filePath;
            if (string.IsNullOrEmpty(path))
                path = winDir + "\\system.ini";
            StreamReader reader = new StreamReader(path); 
            try{
                do textInMemory.Add(reader.ReadLine());
                while (reader.Peek() != -1);
            }
               
            catch{
                textInMemory.Add("File is Empty");
            }
            finally {
                reader.Close();
            }

            Display(textInMemory);
        }

        private static void Display(List<string> lineOfText)
        {

            foreach(string line in lineOfText)
                Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}
