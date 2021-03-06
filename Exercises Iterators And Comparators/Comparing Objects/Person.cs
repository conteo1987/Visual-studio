﻿using System;

namespace Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }
        public int CompareTo(Person other)
        {
            var compareson = this.name.CompareTo(other.name);
            if (compareson !=0)
            {
                return compareson;
            }
            compareson = this.age.CompareTo(other.age);
            if (compareson != 0)
            {
                return compareson;
            }
            return this.town.CompareTo(other.town);
        }
    }
}
