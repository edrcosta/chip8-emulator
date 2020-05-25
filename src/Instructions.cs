namespace chip8emu
{
    public class Instructions
    {   
        string[][] opCodeTable = new string[][] 
        {
            new string[] {"0NNN", "Call", "Calls RCA 1802 program at address NNN. Not necessary for most ROMs."},
            new string[]{"00E0", "Display", "disp_clear() Clears the screen."},
            new string[]{"00EE", "Flow", "return; Returns from a subroutine."},
            new string[]{"1NNN", "Flow", "goto NNN; Jumps to address NNN."},
            new string[]{"2NNN", "Flow", "*(0xNNN)() Calls subroutine at NNN."},
            new string[]{"3XNN", "Cond", "if(Vx==NN) Skips the next instruction if VX equals NN. (Usually the next instruction is a jump to skip a code block)"},
            new string[]{"4XNN", "Cond", "if(Vx!=NN) Skips the next instruction if VX doesn't equal NN. (Usually the next instruction is a jump to skip a code block)"},
            new string[]{"5XY0", "Cond", "if(Vx==Vy) Skips the next instruction if VX equals VY. (Usually the next instruction is a jump to skip a code block)"},
            new string[]{"6XNN", "Const", "Vx = NN Sets VX to NN."},
            new string[]{"7XNN", "Const", "Vx += NN Adds NN to VX. (Carry flag is not changed)"},
            new string[]{"8XY0", "Assign", "Vx=Vy Sets VX to the value of VY."},
            new string[]{"8XY1", "BitOp", "Vx=Vx|Vy Sets VX to VX or VY. (Bitwise OR operation)"},
            new string[]{"8XY2", "BitOp", "Vx=Vx&Vy Sets VX to VX and VY. (Bitwise AND operation)"},
            new string[]{"8XY3__a", "BitOp", "Vx=Vx^Vy Sets VX to VX xor VY."},
            new string[]{"8XY4", "Math", "Vx += Vy Adds VY to VX. VF is set to 1 when there's a carry, and to 0 when there isn't."},
            new string[]{"8XY5", "Math", "Vx -= Vy VY is subtracted from VX. VF is set to 0 when there's a borrow, and 1 when there isn't."},
            new string[]{"8XY6__a", "BitOp", "Vx>>=1 Stores the least significant bit of VX in VF and then shifts VX to the right by 1.[b]"},
            new string[]{"8XY7__a", "Math", "Vx=Vy-Vx Sets VX to VY minus VX. VF is set to 0 when there's a borrow, and 1 when there isn't."},
            new string[]{"8XYE__a", "BitOp", "Vx<<=1 Stores the most significant bit of VX in VF and then shifts VX to the left by 1.[b]"},
            new string[]{"9XY0", "Cond", "if(Vx!=Vy) Skips the next instruction if VX doesn't equal VY. (Usually the next instruction is a jump to skip a code block)"},
            new string[]{"ANNN", "MEM", "I = NNN Sets I to the address NNN."},
            new string[]{"BNNN", "Flow", "PC=V0+NNN Jumps to the address NNN plus V0."},
            new string[]{"CXNN", "Rand", "Vx=rand()&NN Sets VX to the result of a bitwise and operation on a random number (Typically: 0 to 255) and NN."},
            new string[]{"DXYN", "Disp", "draw(Vx,Vy,N) Draws a sprite at coordinate (VX, VY) that has a width of 8 pixels and a height of N pixels. Each row of 8 pixels is read as bit-coded starting from memory location I; I value doesn’t change after the execution of this instruction. As described above, VF is set to 1 if any screen pixels are flipped from set to unset when the sprite is drawn, and to 0 if that doesn’t happen"},
            new string[]{"EX9E", "KeyOp", "if(key()==Vx) Skips the next instruction if the key stored in VX is pressed. (Usually the next instruction is a jump to skip a code block)"},
            new string[]{"EXA1", "KeyOp", "if(key()!=Vx) Skips the next instruction if the key stored in VX isn't pressed. (Usually the next instruction is a jump to skip a code block)"},
            new string[]{"FX07", "Timer", "Vx = get_delay() Sets VX to the value of the delay timer."},
            new string[]{"FX0A", "KeyOp", "Vx = get_key() A key press is awaited, and then stored in VX. (Blocking Operation. All instruction halted until next key event)"},
            new string[]{"FX15", "Timer", "delay_timer(Vx) Sets the delay timer to VX."},
            new string[]{"FX18", "Sound", "sound_timer(Vx) Sets the sound timer to VX."},
            new string[]{"FX1E", "MEM", "I +=Vx Adds VX to I. VF is set to 1 when there is a range overflow (I+VX>0xFFF), and to 0 when there isn't.[c]"},
            new string[]{"FX29", "MEM", "I=sprite_addr[Vx] Sets I to the location of the sprite for the character in VX. Characters 0-F (in hexadecimal) are represented by a 4x5 font."},
            new string[]{"FX33", "BCD", "set_BCD(Vx);"},
            new string[]{"FX55", "MEM", "reg_dump(Vx,&I) Stores V0 to VX (including VX) in memory starting at address I. The offset from I is increased by 1 for each value written, but I itself is left unmodified.[d]"},
            new string[]{"FX65", "MEM", "reg_load(Vx,&I) Fills V0 to VX (including VX) with values from memory starting at address I. The offset from I is increased by 1 for each value written, but I itself is left unmodified.[d]"},        
        };
    }
}