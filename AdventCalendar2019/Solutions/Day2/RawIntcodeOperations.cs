using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalendar2019.Solutions.Day2
{
    class RawIntcodeOperations
    {
        public readonly int[] operations;

        public RawIntcodeOperations(int[] operations)
        {
           this.operations = operations;
        }


        public int Get(int index)
        {
            return this.operations[index];
        }

        public void Set(int index, int value)
        {
            this.operations[index] = value;
        }
    }
}
