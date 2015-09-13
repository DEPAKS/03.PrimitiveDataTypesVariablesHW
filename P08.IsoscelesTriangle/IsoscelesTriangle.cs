using System;

class IsoscelesTriangle
{
    static void Main()
    {   //I've changed the font of the Console to Lucinda Console in order to get the requested output.
        Console.OutputEncoding = System.Text.Encoding.UTF8; //The code below changes the encoding to the console to UTF8!!! 
        string a = @"   ©
  © ©
 ©   ©
© © © ©
"; //the code doesn't look well formatted but if anything is changed/formatted in it, the printed output in the console will look awful. Tried several times.
        Console.WriteLine(a);
    }
}

// P08: Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
// Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.