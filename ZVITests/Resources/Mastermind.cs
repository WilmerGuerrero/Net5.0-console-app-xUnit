using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind.Resources
{
    public class Mastermind
    {
        private readonly List<CodePeg> code;

        public Mastermind(List<CodePeg> code)
        {
            this.code = code;
        }

        public List<ResultPeg> GetHints(List<CodePeg> guess)
        {
            return CodeValidator.ValidateCode(guess, code);
        }
    }

    public enum CodePeg
    {
        Black,
        Blue,
        Green,
        Red,
        White,
        Yellow,
    }

    public enum ResultPeg
    {
        Black,
        White,
    }
}
