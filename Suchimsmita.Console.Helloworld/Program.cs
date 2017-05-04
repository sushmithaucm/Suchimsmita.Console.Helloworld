using Suchimsmita.Helloword.Infrastrcture.Implementaion;
using Suchimsmita.Helloword.Infrastrcture.InterFace;

namespace Suchimsmita.Console.Helloworld
{
    internal class Program
    {
        private static void Main()
        {
            IConsoleInterface console= new ConsoleService();
            console.WriteTextToConsole("Hello !world");
        }
    }
}
