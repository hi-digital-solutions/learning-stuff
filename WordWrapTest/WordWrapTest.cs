using System;
using Xunit;
using FluentAssertions;
using WordWrap;


namespace WordWrapTest
{
    public class WordWrapTests
    {
        //Need to make the first test relevant to iteration
        [Fact]
        public void GetFirstLineOfText()
        {
            string input = "Hello World, this is the answer to everything!";
            int columnWidth = 11;
            string expected = "Hello World";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetTwoLinesofText()
        {
            string input = "Hello there, this should result in at least two lines!";
            int columnWidth = 11;
            string expected = "Hello there\n,this shoul";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }


    }

}