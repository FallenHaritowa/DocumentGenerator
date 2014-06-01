using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ProcessLogic.Template_Extensions
{
    abstract class Extension
    {
        public int Index;
        public String ExtensionText;
        public String ProcessedText;
        public abstract void Process(List<Entity> entities);
    }
}
