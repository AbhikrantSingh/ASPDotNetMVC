using InterviewLearning.Models;
using InterviewLearning.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace InterviewLearning.Controllers
{
    [ApiController]
    [Route("menu")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [System.Web.Http.HttpPost]
        [Route("{restauntId}")]
        public ActionResult<string> AddMenuToRestaunt(Menu menu, Guid restauntId)
        {
            return  _menuService.AddMenuForRestaunt(restauntId, menu);
        }
        [System.Web.Http.HttpGet]
        [Route("restaunt/{restauntId}")]
        public IEnumerable<Menu> RestauntMenuList(Guid restauntId)
        {
            return _menuService.RestauntMenuList(restauntId);
        }
    }
}