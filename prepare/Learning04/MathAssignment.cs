using System;
using System.Runtime.InteropServices;


namespace Learning04
{    
    class MathAssignment : Assignment
    {
        string _section = "4.1";
        List<string> _problems = new List<string>
        {
            "1 + 1",
            "2 + 4 * 8",
            "6 / 3 + 28"
        };

        public MathAssignment(string studentName, string topic, string section): base(studentName, topic)
        {
            _section = section;
        }

        public void DisplayTextBook()
        {
            Console.WriteLine($"you are currently in section {_section} in math");
        }

        public List<string> GetProblemsList()
        {
            return _problems;
        }
    }
}