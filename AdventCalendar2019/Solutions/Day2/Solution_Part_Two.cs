using System;
using System.Collections.Generic;
using System.Text;
using BaseSolution = AdventCalendar2019.Solutions.Solution;
using AdventCalendar2019.Input;
using System.Linq;

namespace AdventCalendar2019.Solutions.Day2
{
    class Solution_Part_Two : BaseSolution
    {
        IntcodeProcessor _processor = new IntcodeProcessor();
        public Solution_Part_Two() : base() { }
        public Solution_Part_Two(SolutionInput si) : base(si) { }

        public override void Run()
        {
            int targetNumber = 19690720;
            int currentNumber = 0;
            int foundNoun = 0;
            int foundVerb = 0;
            bool found = false;


            for (int noun = 0; noun <= 99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    int[] instructions = GetProcessorInstructions();
                    instructions[1] = noun;
                    instructions[2] = verb;

                    int[] output = _processor.Process(instructions);
                    currentNumber = output[0];

                    if (currentNumber == targetNumber)
                    {
                        found = true;
                        foundNoun = noun;
                        foundVerb = verb;
                        break;
                    }
                }

                if (found == true)
                {
                    break;
                }
            }

            Console.WriteLine("Target: {0}", targetNumber);
            Console.WriteLine("Found: {0}", currentNumber);
            Console.WriteLine("Noun: {0}", foundNoun);
            Console.WriteLine("Verb: {0}", foundVerb);
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
