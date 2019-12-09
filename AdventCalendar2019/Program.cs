using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using AdventCalendar2019.Solutions;
using AdventCalendar2019.Input;

namespace AdventCalendar2019
{
    class Program
    {
        static List<Type> _solutions = new List<Type>();

        static void Main(string[] args)
        {
            _AddSolution("Day1.Solution");
            _AddSolution("Day2.Solution");

            bool exit = false;
            SolutionInput solutionInput = new SolutionInput(@"SolutionData");

            do
            {
                Console.WriteLine("Choose Solution (0 - {0}): ", _solutions.Count - 1);
                string input = Console.ReadLine();
                int numeric = Int32.Parse(input);

                if (numeric == -1)
                {
                    exit = true;
                }
                else
                {
                    Type solutionType = _solutions[numeric];
                    Type[] constructorTypes = new Type[] { Type.GetType("AdventCalendar2019.Input.SolutionInput") };
                    ConstructorInfo constructor = solutionType.GetConstructor(constructorTypes);
                    Solution s = (Solution) constructor.Invoke(new object[] { solutionInput });
                    s.Run();
                }

            } while (!exit);
        }

        static void _AddSolution(string typeName)
        {
            string fullAssemblyName = "AdventCalendar2019.Solutions." + typeName;
            Type t = Type.GetType(fullAssemblyName);
            _solutions.Add(t);
        }
    }
}
