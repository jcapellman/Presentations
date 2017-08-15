using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleApp
{
    public class FunctionExpressionExample
    {
        public class SalesVolume
        {
            public int Year { get; set; }

            public int Amount { get; set; }
        }

        private readonly List<SalesVolume> _volumes;

        public FunctionExpressionExample()
        {
            var random = new Random((int) DateTime.Now.Ticks);

            _volumes = new List<SalesVolume>();
            
            for (var x = 0; x < 100; x++)
            {
                _volumes.Add(new SalesVolume
                {
                    Amount = x,
                    Year = random.Next(1900, DateTime.Now.Year)
                });
            }
        }

        public SalesVolume GetSalesVolume(Func<SalesVolume, bool> expression) => _volumes.FirstOrDefault(expression);
    }
}