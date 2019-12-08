using System;
using System.Collections.Generic;
using System.Text;
using AdventCalendar2019.Input;

namespace AdventCalendar2019.Solutions
{
    class Day1_Solution : Solution
    {

        public Day1_Solution(SolutionInput si) : base(si) { }

        public override void Run()
        {
            double totalModuleRequirements = 0.0f;

            foreach (string sMass in _si.Get("Day1_Solution"))
            {
                double dMass = double.Parse(sMass);
                double moduleRequirements = CalculateModuleRequirements(dMass);
                totalModuleRequirements += moduleRequirements;
            }

            Console.WriteLine("Total Module Requirements: {0}", totalModuleRequirements);
        }

        double CalculateModuleRequirements(double mass)
        {
            double requirement = mass;
            requirement /= 3;
            requirement = Math.Floor(requirement);
            requirement -= 2;
            return requirement;
        }
    }
}
