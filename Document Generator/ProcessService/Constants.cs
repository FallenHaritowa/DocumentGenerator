using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessService
{
    public static class Constants
    {
        public static Dictionary<String, String> DocumentExtensions;
        public Constants()
        {
            DocumentExtensions = new Dictionary<String, String>();
            DocumentExtensions.Add("Word", "docx");
        }
    }
}
