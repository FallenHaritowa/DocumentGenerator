using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using PatternLogic.Template_Extensions;

namespace PatternLogic.Logic_Classes
{
    public static class ExtensionParser
    {
        public List<Extension> GetExtensions(Template template)
        {
            List<Extension> result = new List<Extension>();
            foreach (String pattern in Constants.ExtensionsPatterns)
            {
                Regex reg =new Regex(pattern);
                foreach (Match match in reg.Matches(template.Text))
                {
                    Type extentionType;
                    Extension extension = ExtensionResolver.ResolveExtension(pattern);
                    extension.ExtensionText = match.Value;
                    result.Add(extension);
                }
            }
            return result;
        }
    }
}
