Your task is to write a function that takes two arguments,
a string and an integer width.

The function returns the string, but with line breaks
inserted at just the right places to make sure that no line
is longer than the column number.
You try to break lines at word boundaries.

Like a word processor, break the line by replacing
the last space in a line with a newline.

\
Notes
   //Split the word string into a List
               //Pass list to aggregator/reducer
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