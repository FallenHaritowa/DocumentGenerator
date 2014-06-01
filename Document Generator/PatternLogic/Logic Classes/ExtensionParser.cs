using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ProcessLogic.Template_Extensions;

namespace ProcessLogic.Logic_Classes
{
    internal  class ExtensionParser
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
            result.Sort((s1, s2) => s2.Index.CompareTo(s1.Index));
            return result;
        }
    }
}
