using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IRepository
    {
        string ConnectionString { get; set; }
    }
}
