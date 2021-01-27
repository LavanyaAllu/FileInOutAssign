using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileInOutAssign
{
   /* C# BinaryWriter
    C# BinaryWriter class is used to write binary information into stream. It is found in System.IO namespace. It also supports writing string in specific encoding.

    C# BinaryWriter Example
    Let's see the simple example of BinaryWriter class which writes data into dat file.*/
    class FileBinaryWriter
    {
        static void Main(string[] args)
        {
            string fileName = "e:\\binaryfile.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
