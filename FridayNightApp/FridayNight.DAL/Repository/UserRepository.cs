using FridayNight.DAL.Model;
using FridayNight.DAL.Repository.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(FNContext options) : base(options)
        {
        }
    }
}
