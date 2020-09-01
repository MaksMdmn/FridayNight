using FridayNight.DAL.Model;
using FridayNight.DAL.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayNightApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BimboController : Controller
    {
        private readonly IRepositoryBase<User> _repository;

        
        
        public BimboController(IRepositoryBase<User> repository)
        {
            _repository = repository;
        }


        [HttpGet("[action]")]
        public IActionResult Test()
        {
            _repository.CreateOrUpdate(new User()
            {
                FirstName = "Bodyan",
                LastName = "Bodyan"
            });

            _repository.CreateOrUpdate(new User()
            {
                FirstName = "Sposeba",
                LastName = "Koban"
            });

            return Ok();
        }
    }
}
