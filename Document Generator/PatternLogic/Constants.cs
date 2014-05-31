using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLogic
{
    public static class Constants
    {
        public static List<String> ExtensionsPatterns;
        public Constants()
        {
            ExtensionsPatterns = new List<string>();
            ExtensionsPatterns.Add("{{=*?=}}");
        }
    }
}
