public class Job
{
    public string _company = "";
    public int _startYear = 0;
    public string _jobTitle = "";
    public int _endYear = 0;

    public void DisplayInfo()
    {
        Console.WriteLine(_company);
        Console.WriteLine(_jobTitle);
        Console.WriteLine(_startYear);
        Console.WriteLine(_endYear);
    }
}