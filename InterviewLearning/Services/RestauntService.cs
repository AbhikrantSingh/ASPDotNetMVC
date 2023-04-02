using InterviewLearning.Models;
using InterviewLearning.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Services
{
    public class RestauntService : IRestauntService
    {
        private readonly IRestauntRepo _restauntRepo;

        public RestauntService(IRestauntRepo restauntRepo)
        {
            _restauntRepo = restauntRepo;
        }

        public IEnumerable<Restaunt> GetAllRestaunt()
        {
            return _restauntRepo.GetAllRestaunt();
        }

        public IEnumerable<Restaunt> GetAllUserRestaunt(Guid userId)
        {
           return _restauntRepo.GetAllUserRestaunt(userId);
        }

        public string saveRestaunt(Guid userId, Restaunt restaunt)
        {
            return _restauntRepo.saveRestaunt(userId, restaunt);
        }
    }
}
