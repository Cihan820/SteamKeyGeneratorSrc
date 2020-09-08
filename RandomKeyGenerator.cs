using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;

namespace SteamKeyGen
{
  public class RandomKeyGenerator
  {
    private string Key_Letters;
    private string Key_Numbers;
    private int Key_Chars;
    private char[] LettersArray;
    private char[] NumbersArray;

    protected internal string KeyLetters
    {
      set => this.Key_Letters = value;
    }

    protected internal string KeyNumbers
    {
      set => this.Key_Numbers = value;
    }

    protected internal int KeyChars
    {
      set => this.Key_Chars = value;
    }

    public string Generate()
    {
      StringBuilder stringBuilder = new StringBuilder();
      this.LettersArray = this.Key_Letters.ToCharArray();
      this.NumbersArray = this.Key_Numbers.ToCharArray();
      int keyChars = this.Key_Chars;
      int num1 = 1;
      while (num1 <= keyChars)
      {
        VBMath.Randomize();
        float num2 = VBMath.Rnd();
        short num3 = -1;
        if (checked ((int) Math.Round(unchecked ((double) num2 * 111.0))) % 2 == 0)
        {
          while (num3 < (short) 0)
            num3 = Convert.ToInt16((float) this.LettersArray.GetUpperBound(0) * num2);
          string upper = Conversions.ToString(this.LettersArray[(int) num3]);
          if ((uint) checked ((int) Math.Round(unchecked ((double) num3 * (double) num2 * 99.0))) % 2U > 0U)
            upper = this.LettersArray[(int) num3].ToString().ToUpper();
          stringBuilder.Append(upper);
        }
        else
        {
          while (num3 < (short) 0)
            num3 = Convert.ToInt16((float) this.NumbersArray.GetUpperBound(0) * num2);
          stringBuilder.Append(this.NumbersArray[(int) num3]);
        }
        checked { ++num1; }
      }
      return stringBuilder.ToString();
    }
  }
}
