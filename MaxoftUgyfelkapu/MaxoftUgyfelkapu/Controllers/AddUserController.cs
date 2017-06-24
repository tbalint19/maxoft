using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MaxoftUgyfelkapu.Controllers
{
    public class AddUserController : ApiController
    {
        // POST: AddUser
        public Dictionary<string, Boolean> Post([FromBody]string value)
        {
            var response = new Dictionary<string, Boolean>();
            response.Add("is_successful", true);
            return response;
        }
    }
}