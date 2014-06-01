using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProcessLogic.Template_Extensions
{
    public class ShuffleExtension:Extension
    {
        public override void Process(List<Entity> entities,)
        {
            String text = ExtensionText;
            text = text.Replace("{{^", "").Replace("^}}", "");
            Regex wordCount=new Regex("(*?)");
            if(wordCount.IsMatch(text) && new Regex("{*?}").IsMatch(text))
            {
                Match match = wordCount.Match(text);
                ProcessedText.Replace(match.Value,"");
                int count = int.Parse(match.Value.Replace("(", "").Replace(")", ""));
                match.NextMatch();
                ProcessedText.Replace(match.Value,"");
                String separator=match.Value.Replace("(","").Replace(")","");
                List<String> words = new List<String>(text.Replace(match.Value, "").Replace("{", "").Replace("}", "").Split(','));
                if (words.Count < count)
                {
                    throw new Exception(String.Format("There is template Error: {0} Selected word counts is more than words written",ExtensionText));
                }
                Random Shuffler = new Random();
                int counter = 0;
                String result="";
                while (counter < count)
                {
                    String word=words[Shuffler.Next(words.Count - counter - 1)];
                    result+=word+separator;
                    words.Remove(word);
                }
                ProcessedText=result;
            }
            else
            {
                throw new Exception(String.Format("There is template Error: {0} it should be {{^(select word count)(word separator){word1,word2,word3,word4....}^}} ",ExtensionText));
            }

        }
    }
}
