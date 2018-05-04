using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GmailClient.Controllers
{
    [Route("api/[controller]")]
    public class MailController : Controller
    {
        // GET api/mail
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
