using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Model.Abstract
{
    public abstract class ActionRecordBase : ModelBase
    {
        public DateTime DateTime { get; set; }
    }
}
