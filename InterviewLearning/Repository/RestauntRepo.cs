using InterviewLearning.Data;
using InterviewLearning.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Repository
{
    [EnableCors("CorsPolicy")]
    public class RestauntRepo : IRestauntRepo
    {
        private readonly ApplicationDbContext _db;

        public RestauntRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Restaunt> GetAllRestaunt()
        {
            return _db.restaunts.ToList();
        }

        public IEnumerable<Restaunt> GetAllUserRestaunt(Guid userId)
        {
            //var user = _db.users.FirstOrDefault(u => u.UserId == userId);
            //var result = _db.restaunts.Where(res => res.userId == user.UserId).ToList();
            var res = _db.restaunts
                      .Where(r => r.userId == userId)
                      .ToList();

            return res;
        }

        public string saveRestaunt(Guid userId, Restaunt restaunt)
        {
            var user = _db.users.FirstOrDefault(u => u.UserId == userId);
            restaunt.userId = user.UserId;
            _db.restaunts.Add(restaunt);
            _db.SaveChanges();
            return "Added Successfully";
        }
    }
}