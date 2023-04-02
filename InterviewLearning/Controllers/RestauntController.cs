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
    [Route("restaunt")]
    public class RestauntController : ControllerBase
    {
        private readonly IRestauntService restauntService;

        public RestauntController(IRestauntService restauntService)
        {
            this.restauntService = restauntService;
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<Restaunt> GetAllRestauntd()
        {
            return restauntService.GetAllRestaunt();
        }

        [System.Web.Http.HttpGet]
        [Route("{userId}")]
        public IEnumerable<Restaunt> GetAllUsetRestaunts(Guid userId)
        {
            return restauntService.GetAllUserRestaunt(userId);
        }

        [System.Web.Http.HttpPost]
        [Route("save/{userId}")]
        public ActionResult<string> SaveRestaunt( Restaunt restaunt, Guid userId)
        {
            return restauntService.saveRestaunt(userId, restaunt);
        }
    }

}
