using System;
using System.IO;
using System.Text;

namespace chip8emu
{
    class FileParsing
    {
        public static void GetFile(string fileName)
        {
            byte[] data = File.ReadAllBytes(fileName);
            string fileData = System.Text.Encoding.UTF8.GetString(data);

            foreach(int opcode in data){
                Console.WriteLine(opcode);
            }

            // Console.WriteLine(fileData); // writes 32715 to the console
        }

        // public static String FormatHex(byte[] data){
        //     
        // }

        // public static byte[] ReadFully(Stream input)
        // {
        //     byte[] buffer = new byte[16*1024];
        //     using (MemoryStream ms = new MemoryStream())
        //     {
        //         int read;
        //         while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
        //         {
        //             ms.Write(buffer, 0, read);
        //         }
        //         return ms.ToArray();
        //     }
        // }
    }
}
