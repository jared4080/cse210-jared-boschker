public class Resume
{
    public string _userName = "";
    public List<string> _jobs = new List<string>();

    public void DisplayInfo()
    {
        Console.WriteLine(_userName);
        foreach (string job in _jobs)
        {
            Console.WriteLine(job);
        }
    }
}