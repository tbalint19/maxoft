using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MaxoftUgyfelkapu.Controllers
{
    public class ModifyRoleController : ApiController
    {

        // POST: api/ModifyRole
        public Dictionary<string, Boolean> Post([FromBody]string value)
        {
            var response = new Dictionary<string, Boolean>();
            response.Add("is_successful", true);
            return response;
        }

    }
}
