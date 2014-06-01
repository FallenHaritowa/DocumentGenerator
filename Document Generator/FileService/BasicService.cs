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
    public class BasicService<TBasic> where TBasic : Basic
    {
        protected String directoryPath;

        public void Save(TBasic basicEntity)
        {
            var serializer = new XmlSerializer(typeof(TBasic));
            using (var fileStream = new FileStream(Path.Combine(directoryPath, basicEntity.Name + ".xml"), FileMode.OpenOrCreate))
            {
                serializer.Serialize(fileStream, basicEntity);
            }
        }

        public TBasic Read(String basicName)
        {
            var serializer = new XmlSerializer(typeof (TBasic));
            using (var fileStream = new FileStream(Path.Combine(directoryPath, basicName + ".xml"), FileMode.Open))
            {
                return (TBasic)serializer.Deserialize(fileStream);
            }
        }
    }
}
