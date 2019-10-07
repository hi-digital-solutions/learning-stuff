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
        while(words.Length > columnWidth){
          //while the length of the string of words is greater than
          //column width add a newline to the string after 
        }
        return words.Substring(0, columnWidth);
        
      }


    }
}
