using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ProcessService;
using ProcessLogic.Template_Extensions;
using System.IO;

namespace ProcessLogic.Logic_Classes
{
    public class TemplateProcesser
    {
        public void ProcessTemplate(List<Entity> entites,String templateName ,String templateType,String DirectoryPath)
        {
            Template template=new Template();
            ServiceResolver service=new ServiceResolver();
            String GeneratedDocPath = service.GetOutputFilePath(DirectoryPath, templateType, templateName);
            File.Copy(new ServiceResolver().GetTemplateFilePath(templateName,templateType),GeneratedDocPath);
            template.Text = service.GetTemplateFileText(templateName, templateType);
            template.Entities = entites;
            List<Extension> extensions = new ExtensionParser().GetExtensions(template);
            foreach (Extension e in extensions)
            {
                e.Process(template.Entities);
                service.ReplaceTextInFile(GeneratedDocPath,e.ExtensionText,e.ProcessedText,templateType);
            }
        }
    }
}