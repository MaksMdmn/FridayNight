using FridayNight.Core.Models;
using FridayNight.Core.Services.Interfaces;
using FridayNight.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Core.Services.Implementations
{
    public class TalentSeekerService : ITalentSeekerService
    {
        private readonly ITalentSeekerRepository _repository;

        public TalentSeekerService(ITalentSeekerRepository repository)
        {
            _repository = repository;
        }

        public void Register(TalentSeekerRegistrationSpec registrationSpec)
        {
            throw new NotImplementedException();
        }

        private void RegisterQuickFlow(TalentSeekerRegistrationSpec registrationSpec)
        {

        }

        private void RegisterUsualFlow(TalentSeekerRegistrationSpec registrationSpec)
        {

        }
    }
}
