using System;
using System.IO;

namespace ReadATextFile
{
    class Program
    {

        static readonly string textFile = @"D:\29-09-2021.pu";


        static void Main(string[] args)
        {
            int count = 0;
            int indexofcount;
            int countfile = 0;
            string FileName = textFile.Substring(3, 10);

            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);

                string firstline = lines[0].ToString();
                if (!firstline.Contains(FileName))
                {
                    Console.WriteLine("invalid file");
                }
                foreach (string line in lines)
                {
                    count++;

                }

                if (firstline.Contains("count"))

                {
                    indexofcount = firstline.IndexOf("count");
                    string countfile1 = firstline.Substring(indexofcount + 6);

                    int ff = Convert.ToInt32(countfile1);
                    if (ff != count - 1)
                    {
                        Console.WriteLine("invalid file");
                    }
                }



                string x = DateTime.Now.ToString("dd-MM-yyyy");
                System.IO.File.Move("D:\\29-09-2021.pu", "D:\\" + x + ".ur");

                //  System.IO.File.Move("D:\\29-09-2021.pu", "D:\\29-09-2021.ur");


            }


            Console.ReadKey();
        }

    }
}