using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Common.Abstract
{
    public interface IEntity
    {
        Guid? Uid { get; set; }
    }
}
