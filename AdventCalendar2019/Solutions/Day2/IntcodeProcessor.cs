using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalendar2019.Solutions.Day2
{

    struct IntcodeOperation
    {
        public const int ADD = 1;
        public const int MUL = 2;
        public const int HALT = 99;

        public readonly int opcode;
        public readonly int[] args;
        public readonly int outputIndex;

        public IntcodeOperation(int opcode, int _argv, int _argc, int outputIndex)
        {
            this.opcode = opcode;
            this.args = new int[]{ _argv, _argc };
            this.outputIndex = outputIndex;
        }
    }

    struct IntcodeOperationResult
    {
        public readonly int value;
        public readonly int outputIndex;

        public IntcodeOperationResult(int value, int outputIndex)
        {
            this.value = value;
            this.outputIndex = outputIndex;
        }
    }


    public class IntcodeProcessor
    {
        public int[] Process(int[] input)
        {
            int[] output = input;
            bool halt = false;
            int offset = 0;

            while (halt == false)
            {
                IntcodeOperation op = GetOperation(offset, output);

                if (op.opcode == IntcodeOperation.HALT)
                {
                    halt = true;              
                } else
                {
                    IntcodeOperationResult result = ProcessOperation(op);
                    output.SetValue(result.value, result.outputIndex);
                }

                offset += 4;
            }

            return output;
        }

        IntcodeOperation GetOperation(int idx, int[] input)
        {
            int opcode = input[idx];

            if (IntcodeOperation.HALT == opcode)
            {
                return new IntcodeOperation(opcode, 0, 0, 0);
            }

            int lval = input[idx + 1];
            int rval = input[idx + 2];
            int output = input[idx + 3];
            return new IntcodeOperation(opcode, input[lval], input[rval], output);
        }
        
        IntcodeOperationResult ProcessOperation(IntcodeOperation operation)
        {
            int value = 0;

            switch (operation.opcode)
            {
                case IntcodeOperation.ADD:
                    value = operation.args[0] + operation.args[1];
                    break;
                case IntcodeOperation.MUL:
                    value = operation.args[0] * operation.args[1];
                    break;
                default:
                    throw new Exception("Ran into unmapped opcode: " + operation.opcode.ToString());
            }

            return new IntcodeOperationResult(value, operation.outputIndex);
        }
    }
}
