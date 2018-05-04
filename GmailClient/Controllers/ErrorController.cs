﻿using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace GmailClient.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/error")]
        public IActionResult Error()
        {
            var feature = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = feature?.Error;
            if(exception != null)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
            return Ok();
        }
    }
}
