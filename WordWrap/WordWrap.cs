using System;
using System.Collections.Generic;
using System.Linq;


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
           if (words.Length < columnWidth)
           {
               return words;
           }
           else if ( words.Length > columnWidth)
           {
               List<string> wordsList = words.Split(" ").ToList();
               List<string> answerBuilder;
               //Split the word string into a List
               //Pass list to aggregator/reduces
                    //Count length of first word in List
                    //Check if word is longer than columWidth state
                    //If no, 
                        //add word to answer builder List (.Add(x))
                        //Decrement starting columwidth by word length plus 1 (account for space)
                        //Remove word from words List
                    //Pass List again and repeat
                //If yes 
                    //add newline character to answerBuilder
                    //Reset columnWidth state
                    //Pass List again
           }
           return "";
            
        }


    }
}
