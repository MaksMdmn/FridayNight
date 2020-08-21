using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository
{
    public interface IEntity
    {
        Guid Uid { get; set; }
    }
}
