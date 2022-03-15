using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPrj1.Models;

namespace WebApiPrj1.Controllers
{
    [RoutePrefix("api/Person")]
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{Id=1,Name="Rohan",City="Mumbai"},
            new Person{Id=2,Name="Sudha",City="Hyderabad"},
            new Person{Id=3,Name="Priya",City="Chennai"},
            new Person{Id=4,Name="Vikram",City="Delhi"},
        };
        [HttpGet]
        //Get
        [Route("persondetails")]
        
        public IEnumerable<Person> Get()
        {
            return personlist;
        }
        [HttpGet]
        [Route("personlist")]
        public HttpResponseMessage GetPersonList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);
            return response;
        }

        //public HttpResponseMessage GetP(int pid)
        //{
        //    var person = personlist.Find(x => x.Id == pid);

        //    if (person == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound, pid);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, person);
        //}

        //Post

        //public void Post([FromUri]int Id, string Name,string City)
        //{
        //    Person p = new Person();
        //    p.Id = Id;
        //    p.Name = Name;
        //    p.City = City;
        //    personlist.Add(p);

        //}
        public Person Post([FromBody] Person p)
        { 
             personlist.Add(p);
            return p;
        }

        //edit
        public void Put(int id, [FromBody]Person person)
        {
            personlist[id - 1] = person;
        }
          
        //delete
        public void Delete(int id)
        {
            personlist.RemoveAt(id - 1);
        }

        //implementing IHttpActionResult

        //public IHttpActionResult GetbyId(int pid)
        //{
        //    var person = personlist.Find(x => x.Id == pid);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(person);
        //}
        public IHttpActionResult GetName(int pid)
        {
          string person = personlist.Where(x => x.Id == pid).SingleOrDefault()?.Name;

            if (person == null)
            {
                return NotFound();
            }
            return new MyResult(person, Request);
        }

    }


}

