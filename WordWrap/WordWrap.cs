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

      public Answer(string words, int columnWidth)
      {
        this.Words = GetAnswer(words,columnWidth);
      }

      private string GetAnswer(string words, int columnWidth)
      {
        if (words.Length <= columnWidth)
          {
            return words;
          }
        else if (words.Length <= columnWidth*2)
        {
          int index = 0;
            string nextLine = "\n" + words.Substring(index += columnWidth, columnWidth);
            return words.Substring(0, columnWidth) + nextLine;
        }
        else if(words.Length <= columnWidth *3)
          {
            int index = 0;
            index +=columnWidth;
            string nextLine = "\n" + words.Substring(index, columnWidth);
            index += columnWidth;
            string nextNextLine = "\n" + words.Substring(index, columnWidth);
            return words.Substring(0, columnWidth) + nextLine + nextNextLine;
          }
        else
        {
           int index = 0;
            index +=columnWidth;
            string nextLine = "\n" + words.Substring(index, columnWidth);
            index += columnWidth;
            string nextNextLine = "\n" + words.Substring(index, columnWidth);
            index += columnWidth;
            string nextNextNextLine = "\n" + words.Substring(index, columnWidth);
            return words.Substring(0, columnWidth) + nextLine + nextNextLine + nextNextNextLine ;
        }

      }


    }
}
