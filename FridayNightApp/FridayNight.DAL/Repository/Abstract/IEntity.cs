using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repository.Abstract
{
    public interface IEntity
    {
        Guid? Uid { get; set; }
    }
}
