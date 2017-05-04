
using System;
using Suchimsmita.Helloword.Infrastrcture.InterFace;


namespace Suchimsmita.Helloword.Infrastrcture.Implementaion
{
    public class ConsoleService : IConsoleInterface
    {
        

        public void WriteTextToConsole(string text)
        {
            try
            {
                Console.WriteLine(text);
            }
            catch (Exception exception)
            {
                if (exception.InnerException != null) throw exception.InnerException;
            }
        }

        public string ReturnTextToApiService(string text)
        {
            return "Hello" + text;
        }
    }
}
