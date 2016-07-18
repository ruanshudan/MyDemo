using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcDemo.Controllers
{
    public class ProcessNameController : ApiController
    {
        // GET api/processname
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/processname/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/processname
        public void Post([FromBody]string value)
        {
        }

        // PUT api/processname/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/processname/5
        public void Delete(int id)
        {
        }
    }
}
