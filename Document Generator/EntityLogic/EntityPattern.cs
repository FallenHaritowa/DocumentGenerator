using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class EntityPattern : Basic
    {
        public IList<String> Fields;
    }
}
