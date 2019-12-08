using System;
using System.Collections.Generic;
using System.Text;
using AdventCalendar2019.Input;

namespace AdventCalendar2019.Solutions
{
    abstract class Solution
    {
        protected SolutionInput _si;

        public Solution(SolutionInput si)
        {
            SetSolutionInput(si);
        }

        public void SetSolutionInput(SolutionInput si)
        {
            _si = si;
        }

        abstract public void Run();
    }
}
