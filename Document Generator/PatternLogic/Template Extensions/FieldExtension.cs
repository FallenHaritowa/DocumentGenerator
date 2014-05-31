using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLogic.Template_Extensions
{
    public class FieldExtension:Extension
    {
        public override void Process(List<Entity> entities)
        {
            String processText = ExtensionText;
            processText = processText.Replace("{{=","").Replace("=}}","");
            processTextParts=processText.Split(".");
            String result=entities.First(e=>e
            
        }
    }
}
