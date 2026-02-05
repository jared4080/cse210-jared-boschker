using System;


namespace Learning04
{    
    class Assignment
    {
        string _studentName = "";
        string _topic = "";


        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        public string GetSummary()
        {
            return _topic + " | name: " + _studentName;
        }
    }
}