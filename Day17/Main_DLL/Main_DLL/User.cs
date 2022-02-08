using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_DLL
{
    public class User
    {
        public Boolean IsAdmin { get; set; }
    }

    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;
            if (MadeBy == user)
                return true;
            else return false;
        }

    }
}
