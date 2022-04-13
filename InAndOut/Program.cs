using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace InAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> txt = new List<string>();
            StreamReader source_read = new StreamReader("C://Users/admin/Desktop/text.txt");
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
            source_write.Close();
        }
    }
}
