using FridayNight.Core.Models;
using FridayNight.Core.Services.Interfaces;
using FridayNight.DAL.Repositories.Interfaces;
using FridayNight.Library.Common.Mapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FridayNight.Core.Services.Implementations
{
    public class TalentSeekerService : ITalentSeekerService
    {
        private readonly ITalentSeekerRepository _repository;
        private readonly ILayerLevelMapper _mapper;

        public TalentSeekerService(ITalentSeekerRepository repository, ILayerLevelMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Register(TalentSeekerRegistrationSpec registrationSpec)
        {
            var talentSeeker = new TalentSeeker()
            {
                Email = registrationSpec.Email,
                Password = registrationSpec.Password,
                Name = registrationSpec.Name,
                Phone = registrationSpec.Phone,
                IsConfirmed = false,
                Login = registrationSpec.Email,
                RegistrationDate = DateTime.Now,
                MusicPreferences = new MusicPreferences()
                {
                    MusicStyles = registrationSpec.FavoriteMusicStyles.Select(
                        musicStyleEnum => new MusicStyle() 
                        { 
                            Name = musicStyleEnum 
                        }).ToList()
                }
            };

            _repository.CreateOrUpdate(
                _mapper.Map<DAL.Models.TalentSeeker>(talentSeeker)
                );
        }
    }
}
