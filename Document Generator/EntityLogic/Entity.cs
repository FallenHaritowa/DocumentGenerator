﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Entity : Basic
    {
        public String PatternName;
        public List<Field> Fields;
    }
}
