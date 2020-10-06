using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repositories.Abstract
{
    public interface IEntity
    {
        Guid? Uid { get; set; }
    }
}
