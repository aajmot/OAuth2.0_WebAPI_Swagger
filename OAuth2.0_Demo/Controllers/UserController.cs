using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;

namespace OAuth2._0_Demo.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                //string token =
                //"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWV9.TJVA95OrM7E2cBab30RMHrHDcEfxjoYZgeFONFh7HgQ";
                //var parts = token.Split('.');
                //var decoded = Convert.FromBase64String(parts[1]);
                //var part = Encoding.UTF8.GetString(decoded);
                //var jwt = JObject.Parse(part);
                //var name = jwt["time"].Value<string>();
                //var username = jwt["username"].Value<string>();

                ClaimsPrincipal principal = Request.GetRequestContext().Principal as ClaimsPrincipal;

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
