using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "valve";
        job1._jobTitle = "keep track of money";
        job1._startYear = 2026;
        job1._endYear = 2028;
        job1.DisplayInfo();
    }
}
