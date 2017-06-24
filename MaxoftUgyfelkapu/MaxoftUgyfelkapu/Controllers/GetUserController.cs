using MaxoftUgyfelkapu.Services;
using MaxoftUgyfelkapu.sqlUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;

namespace MaxoftUgyfelkapu.Controllers
{
    public class GetUserController : ApiController
    {
        // GET: GetUser
        public Dictionary<string, List<string>> Get()
        {
            AuthService authService = new AuthService();
            var token = HttpContext.Current.Request.Headers["auth-token"];
            string username = authService.validateToken(token);

            SqlHelper helper = new SqlHelper("UgyfelSelectByUserName");
            helper.addParam("@UserName", SqlDbType.VarChar, "levi");
            var response = new Dictionary<string, List<string>>();
            response.Add("user", helper.getData()[0]);
            return response;
        }
    }
}