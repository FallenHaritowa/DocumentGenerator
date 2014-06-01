using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessService
{
    internal abstract class BaseService
    {
        public abstract String GetDocumentText (String templateName);
        public abstract void ReplaceStringInText(String outputFilePath,String originText,String replaceText);
    }
}
