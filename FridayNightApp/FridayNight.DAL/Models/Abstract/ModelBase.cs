using FridayNight.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FridayNight.DAL.Models.Abstract
{
    public abstract class ModelBase : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Uid { get; set; }
    }
}
