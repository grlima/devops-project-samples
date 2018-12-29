using GsmWebApi.Models;
using System.Web.Http;

namespace GsmWebApi.Controllers
{
    public class ValidationController : ApiController
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