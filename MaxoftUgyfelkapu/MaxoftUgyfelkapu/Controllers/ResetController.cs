using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

public class ResetJson
{
    public string username { get; set; }
}

namespace MaxoftUgyfelkapu.Controllers
{
    public class ResetController : ApiController
    {
        // POST: reset
        public Dictionary<string, Boolean> Post(ResetJson reset)
        {
            System.Diagnostics.Debug.WriteLine(reset.username);
            var response = new Dictionary<string, Boolean>();
            response.Add("isSuccessful", true);
            return response;
        }
    }
}