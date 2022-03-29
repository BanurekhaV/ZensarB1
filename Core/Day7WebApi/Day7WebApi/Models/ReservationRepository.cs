using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day7WebApi.Models
{
    public class ReservationRepository : IReservationRepository
    {
        private Dictionary<int, Reservation> items;

        public ReservationRepository()
        {
            items = new Dictionary<int, Reservation>();
            new List<Reservation>
            {
                new Reservation
                {
                    ID=1,
                    Name="Rakesh",
                    StartLocation="Delhi",
                    EndLocation="Mumbai",
                },
                new Reservation
                {
                    ID=2,
                    Name="Prakash",
                    StartLocation="Delhi",
                    EndLocation="Lucknow",
                },
                new Reservation
                {
                    ID=3,
                    Name="Sagar",
                    StartLocation="Chennai",
                    EndLocation="Hyderabad",
                },
                new Reservation
                {
                    ID= 4,
                    Name="Rithuparna",
                    StartLocation="Bangalore",
                    EndLocation="Kochin",
                }
            }.ForEach(r => AddReservation(r));
        }

        public Reservation AddReservation(Reservation reservation)
        {
            if(reservation.ID==0)
            {
                int key = items.Count;
                while(items.ContainsKey(key))
                {
                    key++;
                }
                reservation.ID = key;
            }
            items[reservation.ID] = reservation;
            return reservation;
        }

        public void DeleteReservation(int Id) => items.Remove(Id);

        public IEnumerable<Reservation> Reservations => items.Values;

        public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;
    }
}
