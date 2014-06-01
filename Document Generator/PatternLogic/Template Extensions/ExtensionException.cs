using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessLogic.Template_Extensions
{
    class ExtensionException:Exception
    {
        private String extention;
        private String field;
        public override string Message
        {
            
            get
            {
                return String.Format("Error with extention {0} field {1}: It can be because there wrong pattern or that field is dont exist");
            }
        }

        public ExtensionException (String extention,String field)
        {
            this.field=field;
            this.extention=field;
        }
    }
}
