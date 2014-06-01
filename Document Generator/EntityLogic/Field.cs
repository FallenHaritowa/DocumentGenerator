using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Field : Basic
    {
        public List<Item> Values;

        public Field()
        {
            Values = new List<Item>();
        }

        public Field(String name, String firstValue)
        {
            Name = name;
            Values = new List<Item> {new Item() {WordCase = Case.Nominative, Value = firstValue}};
        }

        public String GetValue()
        {
            if (Values.Any())
            {
                return Values[0].Value ?? String.Empty;
            }
            return String.Empty;;
        }

        public String GetValue(Case c)
        {
            if (!Values.Any())
            {
                return String.Empty;;
            }
            Item element = Values.Find(item => item.WordCase == c);
            if (element != null && element.Value != null)
            {
                return element.Value;
            }
            return String.Empty;
        }

        public void AddValue(String value, Case c)
        {
            Item element = Values.Find(item => item.WordCase == c);
            if (element != null)
            {
                element.Value = value;
            }
            else
            {
                Values.Add(new Item() {WordCase = c, Value = value});
            }
        }
    }
}
