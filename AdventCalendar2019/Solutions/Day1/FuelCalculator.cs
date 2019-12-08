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
            double requirement = Math.Floor(inputMass / 3) - 2; ;

            // Math.Floor(n / 3) - 2 where n < 6 always returns a 0 or negative fuel requirement
            if (requirement > 6)
            {
                requirement += Calculate(requirement);
            }

            return requirement;
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
