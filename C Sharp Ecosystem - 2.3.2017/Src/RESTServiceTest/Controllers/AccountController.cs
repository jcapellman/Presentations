using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using RESTServiceTest.DataLayer;

namespace RESTServiceTest.Controllers
{
    public class AccountController : ApiController
    {
        public string Get() => "Hello World!";

        public User GetUser(string firstName)
        {
            var eFactory = new EFModel();

            return eFactory.Users.FirstOrDefault(a => a.FirstName == firstName);
        }
    }
}