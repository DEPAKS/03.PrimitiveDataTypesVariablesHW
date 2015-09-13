using System;

class DeclareVariables
{
    static void Main()
    {
        ushort a = 52130;
        sbyte b = -115;
        int c = 4825932;
        byte d = 97;
        short e = -10000;

        Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e);
    }
}

// P01: Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130 (ushort), -115 (sbyte), 4825932 (int), 97 (byte), -10000 (short). Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.