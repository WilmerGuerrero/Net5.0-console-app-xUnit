using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind.Resources
{
    public class CodeValidator
    {
        public static List<ResultPeg> ValidateCode(List<CodePeg> guess, List<CodePeg> code)
        {
            int asserts = 0;
            var resultPeg = new List<ResultPeg>();
            if (ValidateGuessListCount(guess))
            {
                for (int i = 0; i < guess.Count; i++)
                {
                    for(int j = asserts; j < code.Count; j++)
                    {
                        if (guess[i] == code[j]) 
                        {
                            if (guess.IndexOf(guess[i]) == code.IndexOf(code[j]))
                            {
                                resultPeg.Add(ResultPeg.Black);
                                asserts++;
                            }
                            else
                                resultPeg.Add(ResultPeg.White);                           
                        }
                    }
                }
            }
                return resultPeg;
        }

        public static bool ValidateGuessListCount(List<CodePeg> guess) => guess.Count == 4;
    }
}
