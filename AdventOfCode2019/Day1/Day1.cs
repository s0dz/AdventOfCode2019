﻿using System.Collections.Generic;

namespace AdventOfCode2019.Day1
{
    // The Fuel Counter-Upper needs to know the total fuel requirement.
    // To find it, individually calculate the fuel needed for the mass of each module (your puzzle input),
    // then add together all the fuel values.

    // What is the sum of the fuel requirements for all of the modules on your spacecraft?
    public static class Day1
    {
        // Fuel required to launch a given module is based on its mass.
        public static int FuelCounterUpper(List<int> Modules)
        {
            var totalFuel = 0;

            foreach (var module in Modules)
            {
                var fuel = CalculateFuelRequired(module);

                totalFuel += fuel;
            }

            return totalFuel;
        }

        // To find the fuel required for a module:
        // 1) Take its mass
        // 2) Divide by three
        // 3) Round down
        // 4) Subtract 2
        private static int CalculateFuelRequired(int module)
        {
            var fuel = module / 3 - 2;

            return fuel;
        }
    }
}
