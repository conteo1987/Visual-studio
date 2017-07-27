using System.Collections;
using System.Collections.Generic;
using Strategy_Pattern.Models;

namespace Strategy_Pattern.Comparators
{
   public class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
