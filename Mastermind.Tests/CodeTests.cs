using Mastermind.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Mastermind.Tests
{
    public class CodeTests
    {
        [Fact]
        public void Guess_CodeBreakerCode_ReturnsFeedback()
        {
            //Arrange
            var guessed = new List<CodePeg> { CodePeg.White, CodePeg.Yellow, CodePeg.Black, CodePeg.Red };
            var code = new List<CodePeg> { CodePeg.White, CodePeg.Blue, CodePeg.Red, CodePeg.Green };

            //Act
            List<ResultPeg> feedbackCode = CodeValidator.ValidateCode(guessed, code);

            //Assert
            Assert.Equal<ResultPeg>(new List<ResultPeg>() { ResultPeg.Black, ResultPeg.White }, feedbackCode);
        }
    }
}
