using FridayNight.Common.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FridayNight.DataAccessLayer.Repositories.Models
{
    public abstract class EntityWithDbKey : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Uid { get; set; }
    }
}
