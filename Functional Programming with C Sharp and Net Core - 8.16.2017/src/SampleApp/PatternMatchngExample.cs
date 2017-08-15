using System;

namespace SampleApp
{
    public class Car
    {
        public int Hp;

        public int Weight;

        public Car(int hp, int weight)
        {
            Hp = hp;
            Weight = weight;
        }
    }

    public class Camaro : Car
    {
        public Camaro() : base(650, 3685) { }
    }

    public class Viper : Car
    {
        public Viper() : base(645, 3374) { }
    }

    public class PatternMatchngExample
    {
        public void PatternMatchWithSwitch(Car car)
        {
            switch (car)
            {
                case Camaro camaro when camaro.Hp > 600:
                    Console.WriteLine($"Camaro HP - {camaro.Hp}");
                    break;
                case Viper viper when viper.Hp > 700 || viper.Weight < 4000:
                    Console.WriteLine($"Viper HP - {viper.Hp}");
                    break;
            }
        }

        public void PatternMatchIs(Car car)
        {
            if (car is Viper)
            {
                Console.WriteLine("Viper found!");

                return;
            }

            if (car is Camaro && car.Hp > 600)
            {
                Console.WriteLine("Fast Camaro found!");

                return;
            }

            Console.WriteLine("No match found!");
        }
    }
}