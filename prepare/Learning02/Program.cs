using System;
using System.Collections.Generic;


namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1._company = "valve";
            job1._jobTitle = "keep track of money";
            job1._startYear = 2026;
            job1._endYear = 2028;
            job1.DisplayInfo();

            Resume resume1 = new Resume();
            resume1._userName = "Jared";
            resume1._jobs.Add("money making");
            resume1._jobs.Add("dishes");
            resume1._jobs.Add("cooking");
            resume1.DisplayInfo();
        }
    }
}