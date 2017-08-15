using System;

namespace SampleApp
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public static class FunctionalExtensionsExample
    {
        public static bool IsTrue<T>(this T genericObject, Predicate<T> condition) => condition(genericObject);
    }
}