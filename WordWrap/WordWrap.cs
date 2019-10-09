﻿using System;


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
        else
          {
            int index = 0;
            string nextLine = "\n" + words.Substring(index += columnWidth, columnWidth);
            return words.Substring(0, columnWidth) + nextLine;
          }

      }


    }
}
