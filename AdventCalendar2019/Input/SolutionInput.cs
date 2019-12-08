using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventCalendar2019.Input
{
    class SolutionInput
    {
        string _dataPath;

        public SolutionInput(string dataPath)
        {
            _dataPath = dataPath;
        }

        public IEnumerable<string> Get(string solution)
        {
            string filename = GetFilename(solution);

            using (StreamReader sr = File.OpenText(filename))
            {   
                while (sr.Peek() >= 0)
                {
                    yield return sr.ReadLine();
                }
            }
        }

        string GetFilename(string prefix)
        {
            return _dataPath + "/" + prefix + ".txt";
        }
    }
}
