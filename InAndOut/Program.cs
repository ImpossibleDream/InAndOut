using System;
using System.Collections.Generic;
using System.IO;

namespace InAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> txt = new List<string>();
            /*StreamReader source_read = new StreamReader("C://Users/admin/Desktop/text.txt");
            while (source_read.ReadLine() != null)
            {
                txt.Add(source_read.ReadLine());
            }
            source_read.Close();

            StreamWriter source_write = new StreamWriter("C://Users/admin/Desktop/test.txt");
            for (int i=0; i<txt.Count; i++)
            {
                source_write.WriteLine(txt[i]);
            }

            source_write.Flush();
            source_write.Close();*/

            //tring path = "C://Users/admin/Desktop/text.txt";

            //read
            StreamReader sr = new StreamReader("text.txt");
            String line1 = "";
            while ((line1 = sr.ReadLine()) != null)
            {
                Console.WriteLine(line1);
            }
            sr.Close();

            //write
            StreamWriter sw = new StreamWriter("test.txt");
            string[] ss = new string[] { "This is a C# code.", "Today's task." };
            foreach (string s in ss)
            {
                sw.WriteLine(s);
            }
            sw.Flush();
            sw.Close();

            Console.ReadKey();
        }
    }
}
