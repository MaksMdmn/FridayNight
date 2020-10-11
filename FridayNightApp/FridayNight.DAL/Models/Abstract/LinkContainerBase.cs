using FridayNight.DataAccessLayer.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Models.Abstract
{
    public abstract class LinkContainerBase : EntityWithDbKey
    {
        public string Url { get; set; }

    }
}
