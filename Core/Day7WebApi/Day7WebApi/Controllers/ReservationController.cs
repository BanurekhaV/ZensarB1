using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day7WebApi.Models;

namespace Day7WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private IReservationRepository repository;

        public ReservationController(IReservationRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IEnumerable<Reservation> Get() => repository.Reservations;

        [HttpGet("{id}")]
        public ActionResult<Reservation>Get(int id)
        {
            if(id==0)
            {
                return BadRequest("Id has to be passed in the request");
            }
            return Ok(repository[id]);
        }

        [HttpPost]
        public Reservation Post([FromBody] Reservation res) =>
            repository.AddReservation(new Reservation
            {
                Name = res.Name,
                StartLocation = res.StartLocation,
                EndLocation = res.EndLocation
            });

        [HttpDelete]
        public void Delete(int id) => repository.DeleteReservation(id);
    }
}
