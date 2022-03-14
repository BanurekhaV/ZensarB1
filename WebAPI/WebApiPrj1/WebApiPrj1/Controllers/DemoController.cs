using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPrj1.Models;

namespace WebApiPrj1.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> strings = new List<string> { "value0", "value1", "value2", "value3" };

        //GET : api/Demo/
        public IEnumerable<string> Get()
        {
            return strings;
        }

        //GET: api/Demo/2
        public string Get(int id)
        {
            return strings[id];
        }

        //POST type 1

        //public IEnumerable<string> Post([FromBody] string val)
        //{
        //    strings.Add(val);
        //    return strings;
        //}
        [HttpPost]
        //Post Type 2 with a model
        public IEnumerable<string> Addstrings([FromBody] SampleModel m)
        {
            strings.Add(m.name);
            return strings;
        }

        //PUT: api/Demo/id

        public IEnumerable<string> Put(int id, [FromUri] string val)
        {
            strings[id-1] = val;
            return strings;
        }

        //DELETE : api/Demo/id

        public IEnumerable<string> Delete(int id)
        {
            strings.RemoveAt(id);
            return strings;
        }
    }
}
