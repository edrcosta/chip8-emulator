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
    
            byte[] data = FileParsing.GetFile(fileName);

            foreach(byte opCode in data){
                Runtime.ExecuteOpcode(opCode);
            }
        }
    }
}
