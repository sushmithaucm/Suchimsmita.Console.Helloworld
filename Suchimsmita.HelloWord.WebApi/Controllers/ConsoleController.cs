using System.Web.Http;
using Suchimsmita.Helloword.Infrastrcture.Implementaion;
using Suchimsmita.Helloword.Infrastrcture.InterFace;

namespace Suchimsmita.HelloWord.WebApi.Controllers
{
    public class ConsoleController : ApiController
    {
        // GET: api/Console/5
        public string Get(string text)
        {
            IConsoleInterface console = new ConsoleService();
            return console.ReturnTextToApiService(text);
        }

    }
}
