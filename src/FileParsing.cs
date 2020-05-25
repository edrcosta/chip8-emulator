using System;
using System.IO;
using System.Text;

namespace chip8emu
{
    class FileParsing
    {
        public static byte[] GetFile(string fileName)
        {
            return File.ReadAllBytes(fileName);
        }

        // public static String ConvertToUTF8(byte[] data){
        //     return System.Text.Encoding.UTF8.GetString(data);
        // }
    }
}
