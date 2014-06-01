using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessService
{
    public class ServiceResolver 
    {
        public String GetTemplateFileText(String templateName, String templateType)
        {
            switch(templateType)
            {
                case "Word":
                    {
                        return new WordService().GetDocumentText(templateName);
                    }
                default: throw new Exception("Данный тип шаблонов не потдерживается");
            }
        }

        public void ReplaceTextInFile(String outputFilePath,String originalText,String replaceText,String templateType)
        {
            switch (templateType)
            {
                case "Word":
                    {
                        new WordService().ReplaceStringInText(outputFilePath, originalText, replaceText);
                        break;
                    }
                default: throw new Exception("Данный тип шаблонов не потдерживается");
            }
        }


        public String GetOutputFilePath(String templateName, String templateType, String DirectoryPath)
        {
            return String.Format("{0}//{1}.{2}", DirectoryPath, templateName, Constants.DocumentExtensions[templateType]);
        }

        public String GetTemplateFilePath(String templateName, String templateType)
        {
            return String.Format("..//DocumentTemplates//{0}//{1}.{2}", templateType,templateName, Constants.DocumentExtensions[templateType]);
        }
    }
}
