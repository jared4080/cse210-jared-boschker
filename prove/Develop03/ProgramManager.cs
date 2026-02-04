using System;


namespace Develop03
{
    public class ProgramManager
    {
        public void Quit()
        {
            System.Environment.Exit(1);
        }

        public void ClearConsole()
        {
            Console.Clear();
        }
    }
}