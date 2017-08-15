using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleApp
{
    public class TupleExample
    {
        private readonly List<(string name, int age)> _people;

        public TupleExample()
        {
            _people = new List<(string name, int age)> {("John Doe", 32), ("Jane Doe", 30)};
        }

        public (string name, int age) GetRandomPerson()
        {
            var rand = new Random((int)DateTime.Now.Ticks);

            // New for C# 7.1 - note the strongly typed tuple property reference inside a LinQ query
            return _people.Where(a => a.age >= 30).OrderBy(a => rand.Next()).Take(1).FirstOrDefault();
        }
    }
}