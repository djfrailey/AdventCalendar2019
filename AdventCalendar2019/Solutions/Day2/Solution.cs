using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BaseSolution = AdventCalendar2019.Solutions.Solution;
using AdventCalendar2019.Input;

namespace AdventCalendar2019.Solutions.Day2
{
    class Solution : BaseSolution
    {
        IntcodeProcessor _processor = new IntcodeProcessor();
        public Solution() : base() { }
        public Solution(SolutionInput si) : base(si) { }

        public override void Run()
        {
            int[] instructions = GetProcessorInstructions();
            int[] output = _processor.Process(instructions);
            Console.WriteLine("Position 0 is: {0}", output[0]);
        }

        int[] GetProcessorInstructions()
        {
            int[] instructions = new int[0];

            foreach (string sInstructions in _si.Get("Day2_Solution"))
            {
                string[] split = sInstructions.Split(',');
                instructions = split.Select(x => Int32.Parse(x)).ToArray();
                break;
            }

            return instructions;
        }
    }
}
