using GsmWebApi.Models;
using GsmWebApi.Common;
using System.Web.Http;
using System.Collections.Generic;

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
                return BadRequest(ErrorMessages.NoWebtestInRequest);
            }

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

        [HttpPost]
        [Route("validate/webtests")]

        public IHttpActionResult ValidateVsWebTests([FromBody]IEnumerable<VsWebTest> webTests)
        {
            if (webTests == null)
            {
                return BadRequest(ErrorMessages.NoWebtestInRequest);
            }

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}