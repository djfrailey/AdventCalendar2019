using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventCalendar2019.Solutions.Day1
{
    public class FuelCalculator
    {
        public double Calculate(double inputMass)
        {
            return Math.Floor(inputMass / 3) - 2;
        }

        public double Calculate(double[] inputMasses)
        {
            double sum = 0;

            foreach (double mass in inputMasses)
            {
                sum += Calculate(mass);
            }

            return sum;
        }
    }
}
