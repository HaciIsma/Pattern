using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern.Model
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }

        public Person ShallowCopy()
        {
            return MemberwiseClone() as Person;
        }

        public Person DeepCopy()
        {
            Person clone = MemberwiseClone() as Person;
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = Name;
            return clone;
        }
    }
}
