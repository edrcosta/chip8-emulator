using System;
using System.IO;
using System.Text;

namespace chip8emu
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"roms/BLITZ";
    
            FileParsing.GetFile(fileName);
            // FileStream readStream;
            // readStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            // BinaryReader readBinary = new BinaryReader(readStream);

            // byte inbyte;
            // string outbyte;
            // int value;

            // // inbyte = readBinary.ReadByte(); // read in the value: 7F in hex , 127 in decimal
            // value = inbyte << 8; // shift the value 8 bits to the left: 7F 00 in hex, 32512 in decimal
            // inbyte = readBinary.ReadByte(); // read in the next value: CB in hex, 203 in decimal
            // value += inbyte; // add the second byte to the first: 7F CB in hex, 32715 in decimal
            
            
            // Console.WriteLine(FormatHex(ReadFully(readStream))); // writes 32715 to the console
        }

        public static String FormatHex(byte[] data){
            return System.Text.Encoding.UTF8.GetString(data);
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16*1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
