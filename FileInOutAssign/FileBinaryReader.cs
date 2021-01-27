using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInOutAssign
{
    /*C# BinaryReader
    C# BinaryReader class is used to read binary information from stream. It is found in System.IO namespace. It also supports reading string in specific encoding.

    C# BinaryReader Example
    Let's see the simple example of BinaryReader class which reads data from dat file.C# BinaryReader*/
    class FileBinaryReader
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("e:\\binaryfile.dat", FileMode.Create)))
            {

                writer.Write(12.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("e:\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}

