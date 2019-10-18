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
            this.Words = GetAnswer(words, columnWidth);
        }

        private string GetAnswer(string words, int columnWidth)
        {
            if (words.Length <= columnWidth)
            {
                return words;
            }
            else if (words.Length <= columnWidth * 2)//columnWith Index grow by 1 with each line
            {
                int index = 0;
                string firstLine = words.Substring(index, columnWidth);
                index += columnWidth;
                string nextLine = "\n" + words.Substring(index, columnWidth);
                return firstLine + nextLine;
            }
            else 
            {
              int index = 0;
              string firstLine = words.Substring(index, columnWidth);
              string nextLine ="";
              int wordLength = words.Length;
              while( index <= wordLength)
              {
                index += columnWidth;
                nextLine = "\n" + words.Substring(index, columnWidth);
                firstLine += nextLine;
                if(wordLength <= columnWidth)
                {
                    columnWidth = columnWidth - wordLength;  
                    wordLength = 0;
                }
                else
                {
                    wordLength -= columnWidth; 
                }
                   
              }
              return firstLine;
            }

        }


    }
}
