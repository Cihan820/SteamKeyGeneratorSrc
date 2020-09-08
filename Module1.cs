using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

namespace SteamKeyGen
{
  [StandardModule]
  internal sealed class Module1
  {
    [STAThread]
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("SteamKey Gen By Cihan820");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("Give Me Credit :)");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("How Many Keys You Need Generate? ");
      int integer = Conversions.ToInteger(Console.ReadLine());
      FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + Conversions.ToString(integer) + " Steam Keys.txt", FileMode.Create);
      TextWriter newOut = Console.Out;
      StreamWriter streamWriter = new StreamWriter((Stream) fileStream);
      Console.SetOut((TextWriter) streamWriter);
      RandomKeyGenerator randomKeyGenerator = new RandomKeyGenerator();
      randomKeyGenerator.KeyLetters = "ABCDEFGHIJKLMNOPQRSTUVWYZ";
      randomKeyGenerator.KeyNumbers = "0123456789";
      randomKeyGenerator.KeyChars = 5;
      int num1 = integer;
      int num2 = 1;
      while (num2 <= num1)
      {
        randomKeyGenerator.Generate();
        Console.WriteLine(randomKeyGenerator.Generate() + "-" + randomKeyGenerator.Generate() + "-" + randomKeyGenerator.Generate());
        checked { ++num2; }
      }
      Console.SetOut(newOut);
      streamWriter.Close();
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(Conversions.ToString(integer) + " Keys has been generated.");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Press enter to exit :)");
      Console.Read();
    }
  }
}
