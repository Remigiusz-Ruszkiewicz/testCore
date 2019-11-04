using System;
using System.Collections.Generic;
using System.Text;

namespace testCore
{
    public class Reservation
    {
        public bool IsAdmin;
        public User MadeBy { get; set; }
        public bool CanBeCanceledBy(User user)
        {
            return user.IsAdmin || MadeBy == user;
        }
    }
}
