using System;
using Xunit;
using FluentAssertions;
using WordWrap;


namespace WordWrapTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetBackOneLineOfText()
        {
           
            var expectedText = new Answer();

            expectedText.Should().Be("Hello World");
        }
    }

}