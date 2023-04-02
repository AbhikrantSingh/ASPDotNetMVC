using InterviewLearning.Models;
using InterviewLearning.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace InterviewLearning.Controllers
{
    [ApiController]
    [Route("home")] 
    public class HomeController : ApiController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger,IUserService userService)
        {
            _userService = userService;
        }

        [System.Web.Http.HttpGet]
        [Route("user")]   
        public IEnumerable<User> GetAllUser()
        {
           
            var user = new List<User>();
            IEnumerable<User> users = _userService.GetAllUser();
            return users;
        }

            [System.Web.Http.HttpPost]
            [Authorize]
            [Route("login")]
            public User LoginUser(string email,string password)
            {
                var user = _userService.loginUser(email,password);
                if(user ==null)
                {
                    return new User(); 
                }
                return user;
            }

            [System.Web.Http.HttpPost]
            [Route("newUser")]
            public ActionResult<string> SaveUser(User user)
            {
                if (user == null) return null;
            
                return _userService.saveUser(user);
            }
    }
}
