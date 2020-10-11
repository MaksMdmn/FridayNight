using FridayNight.DAL.Models;
using FridayNight.DAL.Repositories.Interfaces;
using FridayNight.DataAccessLayer.Repositories.EntityFrameworkBase;
using Microsoft.EntityFrameworkCore;

namespace FridayNight.DAL.Repositories.Implementations
{
    public class TalentSeekerRepository : RepositoryBase<TalentSeeker>, ITalentSeekerRepository
    {
        public TalentSeekerRepository(DbContext context) : base(context)
        {
        }
    }
}
