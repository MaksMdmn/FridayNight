using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model.Abstract
{
    public abstract class ResourceBase : ModelBase
    {
        public byte[] Resource { get; set; }

    }
}
