using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ProcessLogic.Template_Extensions
{
    public class FieldExtension:Extension
    {
        public override void Process(List<Entity> entities)
        {
            try
            {
            String processText = ExtensionText;
            processText = processText.Replace("{{=","").Replace("=}}","");
            var processTextParts=processText.Split('|');
            String result = entities.First(e => e.Name == processTextParts[0]).Fields.First(f => e.Name == processTextParts[1]).GetValue(processTextParts[2]);
            ProcessedText = result;
            }
            catch
            {
                throw new ExtensionException(processTextParts[0], processTextParts[1]);
            }
            
        }
    }
}
