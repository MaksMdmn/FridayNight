using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Models.Abstract
{
    public abstract class ResourceBase : ModelBase
    {
        public byte[] Resource { get; set; }

    }
}
