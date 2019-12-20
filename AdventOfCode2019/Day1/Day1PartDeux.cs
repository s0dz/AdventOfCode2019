using System.Collections.Generic;

namespace AdventOfCode2019.Day1
{
    // Fuel itself requires fuel just like a module - take its mass, divide by three, round down, and subtract 2.
    // However, that fuel also requires fuel, and that fuel requires fuel, and so on.
    // Any mass that would require negative fuel should instead be treated as if it requires zero fuel;
    // the remaining mass, if any, is instead handled by wishing really hard, which has no mass and is outside the scope of this calculation.

    public class Day1PartDeux
    {
        // So, for each module mass, calculate its fuel and add it to the total.
        // Then, treat the fuel amount you just calculated as the input mass and repeat the process,
        // continuing until a fuel requirement is zero or negative.
        public static int FuelCounterUpper(List<int> Modules)
        {
            var totalFuel = 0;

            foreach (var module in Modules)
            {
                var fuel = RecursiveFuelRequired(module);

                totalFuel += fuel - module;
            }

            return totalFuel;
        }

        private static int CalculateTotalFuelForModule(int module)
        {
            var fuel = FuelAlgorithm(module);

            return RecursiveFuelRequired(fuel);
        }

        // To find the fuel required for a module:
        // 1) Take its mass
        // 2) Divide by three
        // 3) Round down
        // 4) Subtract 2
        private static int RecursiveFuelRequired(int input)
        {
            if (input <= 0)
            {
                return 0;
            }

            var fuel = FuelAlgorithm(input);

            return input + RecursiveFuelRequired(fuel);
        }

        private static int FuelAlgorithm(int input)
        {
            return input / 3 - 2;
        }
    }
}
