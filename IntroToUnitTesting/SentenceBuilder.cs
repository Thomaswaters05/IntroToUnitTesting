using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToUnitTesting
{
    public class SentenceBuilder
    {
        public string BuildSentence(string[] inputWords)
        {
            
            string sentence = "";

           foreach (var word in inputWords)
            {
                sentence += word + " ";
            }
            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            string finishedSentence = sentence[0].ToString().ToUpper() + sentence.Substring(1);

            return finishedSentence;
        }
    }
}
