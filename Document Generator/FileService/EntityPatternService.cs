using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EntityLogic;

namespace FileService
{
    public class EntityPatternService : BasicService<EntityPattern>
    {

        public EntityPatternService()
        {
            directoryPath = "Entity Patterns";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}
