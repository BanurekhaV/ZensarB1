using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day7WebApi.Models
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> Reservations { get; }
        Reservation AddReservation(Reservation reservation);
        Reservation this[int id] { get; } // get reservation by id
        void DeleteReservation(int id);
    }
}
