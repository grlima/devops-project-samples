using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GsmWebApi.Models;

namespace GsmWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpPost]
        [Route("validate/webtest")]
        
        public IHttpActionResult ValidateVsWebTest([FromBody]VsWebTest webTest)
        {
            if (webTest == null)
            {
                return BadRequest("No webtest found in the request body.");
            }

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}
