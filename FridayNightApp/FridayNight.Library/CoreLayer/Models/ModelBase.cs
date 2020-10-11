using FridayNight.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Library.CoreLayer.Models
{
    public abstract class ModelBase : IEntity
    {
        public Guid? Uid { get; set; }
    }
}
