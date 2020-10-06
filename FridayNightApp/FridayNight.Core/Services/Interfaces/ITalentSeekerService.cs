using FridayNight.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Core.Services.Interfaces
{
    public interface ITalentSeekerService
    {
        void Register(TalentSeekerRegistrationSpec registrationSpec);
    }
}
