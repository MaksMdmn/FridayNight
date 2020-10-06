using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Models.Abstract
{
    public abstract class AccountBase : ModelBase
    {
        public DateTime RegistrationDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
