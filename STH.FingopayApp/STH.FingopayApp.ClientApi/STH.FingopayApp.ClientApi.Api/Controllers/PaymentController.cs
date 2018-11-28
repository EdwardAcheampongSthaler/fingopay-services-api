using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using STH.FingopayApp.ClientApi.Api.Controllers.Base;

namespace STH.FingopayApp.ClientApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ApiBaseController
    {

        // POST: api/authorize
        [HttpPost("/authorize")]        
        public void Post([FromBody] string value)
        {
        }


    }
}
