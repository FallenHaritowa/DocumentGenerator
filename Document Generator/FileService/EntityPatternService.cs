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
    public class EntityPatternService
    {
        private const String directoryPath = "Entity Patterns";

        public EntityPatternService()
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public void Save(EntityPattern entitypattern)
        {
            var serializer = new XmlSerializer(typeof(EntityPattern));
            using (var fs = new FileStream(Path.Combine(directoryPath, entitypattern.Name), FileMode.Open))
            {
                serializer.Serialize(fs, entitypattern);
            }
        }
    }
}
