using System;


namespace Learning04
{    
    class Program
    {
        static void Main(string[] args)
        {
            WritingAssignment writingAssignment = new WritingAssignment("jared", "writing and reasoning", "ENG150");
            MathAssignment mathAssignment = new MathAssignment("dwayne johnson", "algebra", "4.1");

            string writingSummary = writingAssignment.GetSummary();
            string writingInfo = writingAssignment.GetWritingInfo();
            Console.WriteLine(writingInfo);
            Console.WriteLine(writingSummary);

            Console.WriteLine();

            mathAssignment.GetSummary();
            mathAssignment.DisplayTextBook();
            List<string> mathProblems = new List<string>();
            mathProblems = mathAssignment.GetProblemsList();

            Console.WriteLine("look at all of these math problems for section! :D");
            foreach (string problem in mathProblems)
            {
                Console.WriteLine(problem);
            }
        }
    }
}