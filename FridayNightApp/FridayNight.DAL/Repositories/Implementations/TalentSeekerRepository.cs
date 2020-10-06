using FridayNight.DAL.Models;
using FridayNight.DAL.Repositories.Abstract;
using FridayNight.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL.Repositories.Implementations
{
    public class TalentSeekerRepository : RepositoryBase<TalentSeeker>, ITalentSeekerRepository
    {
        public TalentSeekerRepository(DbContext context) : base(context)
        {
        }
    }
}
