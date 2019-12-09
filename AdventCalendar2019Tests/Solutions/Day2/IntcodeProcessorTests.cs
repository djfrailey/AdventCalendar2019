using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventCalendar2019.Solutions.Day2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalendar2019.Solutions.Day2.Tests
{
    [TestClass()]
    public class IntcodeProcessorTests
    {
        IntcodeProcessor _processor = new IntcodeProcessor();

        [TestMethod()]
        [DataRow(new int[] { 1, 0, 0, 0, 99 }, new int[] { 2, 0, 0, 0, 99 })]
        [DataRow(new int[] { 2, 3, 0, 3, 99 }, new int[] { 2, 3, 0, 6, 99 })]
        [DataRow(new int[] { 2, 4, 4, 5, 99, 0 }, new int[] { 2, 4, 4, 5, 99, 9801 })]
        [DataRow(new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }, new int[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 })]
        [DataRow(new int[] { 1,9,10,3,2,3,11,0,99,30,40,50, 99}, new int[] { 3500, 9, 10, 70, 2, 3, 11, 0, 99, 30, 40, 50, 99})]
        [DataRow(new int[] { 1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,9,1,19, 99}, new int[] { 1, 12, 2, 2, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 9, 1, 36, 99 })]
        [DataTestMethod]
        public void Test_Process(int[] processorInput, int[] expectedOutput)
        {
            int[] actualOutput = _processor.Process(processorInput);
            Assert.AreEqual(string.Join(",", expectedOutput), string.Join(",", actualOutput));
        }
    }
}