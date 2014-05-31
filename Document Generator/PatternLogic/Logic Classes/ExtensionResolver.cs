using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternLogic.Template_Extensions;

namespace PatternLogic.Logic_Classes
{
    public static class ExtensionResolver
    {
        public  static Extension ResolveExtension(String ExtensionPattern)
        {
            switch (ExtensionPattern)
            {
                case "{{=*?=}}":
                    {
                        return new FieldExtension() { Index = 1 };       
                    }
                default: return null;
            }

        }
    }
}
