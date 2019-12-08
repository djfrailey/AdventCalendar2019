using System;
using System.Collections.Generic;
using System.Text;
using AdventCalendar2019.Input;
using BaseSolution = AdventCalendar2019.Solutions.Solution;

namespace AdventCalendar2019.Solutions.Day1
{
    class Solution : BaseSolution
    {

        FuelCalculator _fc = new FuelCalculator();

        public Solution(SolutionInput si) : base(si) { }

        public override void Run()
        {
            double[] masses = GetMasses();
            double total = _fc.Calculate(masses);
            Console.WriteLine("Total Module Requirements: {0}", total);
        }

        double[] GetMasses()
        {
            List<Double> masses = new List<Double>();

            foreach (string sMass in _si.Get("Day1_Solution"))
            {
                masses.Add(double.Parse(sMass));
            }

            return masses.ToArray();
        }
    }
}
