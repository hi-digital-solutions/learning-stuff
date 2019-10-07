using System;


namespace WordWrap
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    public class Answer
    {

      public string Words;

      public Answer(string words)
      {
        this.Words = GetAnswer(words);
      }

      private string GetAnswer(string words, int columnWidth = 11)
      {
        string substring = words.Substring(0, columnWidth);
        return substring;
      }


    }
}
