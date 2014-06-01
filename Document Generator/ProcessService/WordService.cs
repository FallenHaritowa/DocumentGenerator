using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Word;
namespace ProcessService
{
    internal class WordService:BaseService
    {
            static object matchCase = false;
            static object matchWholeWord = true;
            static object matchWildCards = false;
            static object matchSoundsLike = false;
            static object matchAllWordForms = false;
            static object forward = true;
            static object format = false;
            static object matchKashida = false;
            static object matchDiacritics = false;
            static object matchAlefHamza = false;
            static object matchControl = false;
            static object read_only = false;
            static object visible = true;
            static object replace = 2;
            static object wrap = 1;

        public override string GetDocumentText(String templateName,String templateType )
        {
            String Path=String.Format("..//DocumentTemplates//WordTemplates//{0}.{1}",templateName,Constants.DocumentExtensions["Word"]);
            if (File.Exists(Path))
            {
                try
                {
                    Application document=new Application();
                    String result=document.Documents.Open(Path).Range().ToString();
                    document.Documents.Close();
                    return result;
                }
                catch
                {
                    throw new Exception("Файл темплейта уже используется другой программой");
                }
            }
            else
            {
                throw new Exception("Файл был удалён");
            }
        }

        public override void ReplaceStringInText(String outputFilePath, String originText, String replaceText)
        {
            Application application = new Application();
            application.Documents.Open(outputFilePath);
            Object origText =  originText;
            Object replText = replaceText;
            application.Selection.Find.Execute(ref origText, ref matchCase, ref matchWholeWord,
            ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replText, ref replace,
            ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
            application.Documents.Close();
        }

    }
}
