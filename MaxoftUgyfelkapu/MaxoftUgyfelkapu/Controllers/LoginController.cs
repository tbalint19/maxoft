using MaxoftUgyfelkapu.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;

public class UserJson
{
    public string password { get; set; }
    public string username { get; set; }
}

namespace MaxoftUgyfelkapu.Controllers
{
    public class LoginController : ApiController
    {
        // POST: Login
        public Dictionary<string, Object> Post(UserJson user)
        {
            AuthService authService = new AuthService();
            string token = authService.generateToken(user.username);

            var response = new Dictionary<string, Object>();
            response.Add("authToken", token);
            response.Add("isSuccessful", true);
            
            return response;
        }
    }
}