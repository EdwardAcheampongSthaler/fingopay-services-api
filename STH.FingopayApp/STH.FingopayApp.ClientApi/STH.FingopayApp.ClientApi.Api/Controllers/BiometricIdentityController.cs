using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using STH.FingopayApp.ClientApi.Api.Controllers.Base;

namespace STH.FingopayApp.ClientApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiometricIdentityController : ApiBaseController
    {

        // PUT: api/Enroll
        [HttpPut("/enroll")]
        public void Enroll([FromBody] string value)
        {
        }

        // POST: api/Identify
        [HttpPost("/identify")]
        public void Verify([FromBody] string value)
        {
        }

        // POST: api/VerifiyIdentity
        [HttpPost("/reenroll")]
        public void ReEnroll([FromBody] string value)
        {
        }
        // POST: api/VerifiyIdentity
        [HttpPost("/identify")]        
        public void Identify([FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
