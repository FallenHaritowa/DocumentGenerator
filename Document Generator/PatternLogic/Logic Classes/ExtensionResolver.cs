using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessLogic.Template_Extensions;

namespace ProcessLogic.Logic_Classes
{
    internal static class ExtensionResolver
    {
        public  static Extension ResolveExtension(String ExtensionPattern)
        {
            switch (ExtensionPattern)
            {
                case "{{=*?=}}":
                    {
                        return new FieldExtension() { Index = 2 };       
                    }
                case "{{^*?^}}":
                    {
                        return new ShuffleExtension () {Index = 1 };
                    }
                default: return null;
            }

        }
    }
}
