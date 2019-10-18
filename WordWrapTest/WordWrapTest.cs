using System;
using Xunit;
using FluentAssertions;
using WordWrap;


namespace WordWrapTest
{
    public class WordWrapTests
    {
        [Fact]
        public void GetEmptyLineOfText()
        {
            string input = "";
            int columnWidth = 15;
            string expected = "";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetOneLineOfText()
        {
            string input = "Hello World";
            int columnWidth = 11;
            string expected = "Hello World";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words;

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetTwoLinesofTextWords()
        {
            string input = "Hello there, this shou";
            int columnWidth = 11;
            string expected = "Hello there\n, this shou";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words; 

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetThreeLinesofTextWords()
        {
            string input = "Hello there, this should return t";
            int columnWidth = 11;
            string expected = "Hello there\n, this shou\nld return t";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words; 

            actual.Should().Be(expected);
        }

        
        [Fact]
        public void GetFourLinesofTextWords()
        {
            string input = "Hello there, this should return the right am";
            int columnWidth = 11;
            string expected = "Hello there\n, this shou\nld return t\nhe right am";
            var answer = new Answer(input, columnWidth);
            var actual = answer.Words; 

            actual.Should().Be(expected);
        }

    }

}