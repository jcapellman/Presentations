using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Tuple Example{System.Environment.NewLine}");

            var tupleExample = new TupleExample();

            var person = tupleExample.GetRandomPerson();

            // Note the strongly typed tuples
            Console.WriteLine($"{person.name} - {person.age}");

            Console.ReadKey();

            Console.Clear();
            
            /* ************************************************************** */
            Console.WriteLine($"Pattern Match Switch Example{System.Environment.NewLine}");

            var patternMatchExample = new PatternMatchngExample();

            patternMatchExample.PatternMatchWithSwitch(new Camaro());

            Console.ReadKey();

            Console.Clear();
            
            /* ************************************************************** */
            Console.WriteLine($"Pattern Match Is Example{System.Environment.NewLine}");

            patternMatchExample.PatternMatchIs(new Viper());

            Console.ReadKey();

            Console.Clear();

            /* ************************************************************** */
            Console.WriteLine($"Function Expression Example{System.Environment.NewLine}");

            var result = new FunctionExpressionExample().GetSalesVolume(a => a.Amount > 5);

            Console.WriteLine($"In {result.Year} there was {result.Amount} million in sales");

            Console.ReadKey();
        }
    }
}