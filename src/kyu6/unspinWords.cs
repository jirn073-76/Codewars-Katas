// CSharp

using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string placeholder = "";
    string[] sentence_ = sentence.Split(' ');
    for(int i = 0; i < sentence_.Length; i++)
    {
      if(sentence_[i].Length >= 5)
      {
        for(int i2 = sentence_[i].Length-1; i2 >= 0; i2--)
        {
          placeholder = placeholder + sentence_[i][i2];
        }
        sentence_[i] = placeholder;
        placeholder = "";
      }
    }
    return String.Join(" ", sentence_);
  }
}
