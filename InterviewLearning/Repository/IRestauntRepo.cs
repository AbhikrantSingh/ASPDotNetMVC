using InterviewLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Repository
{
    public interface IRestauntRepo
    {
        IEnumerable<Restaunt> GetAllRestaunt();
        IEnumerable<Restaunt> GetAllUserRestaunt(Guid userId);
        string saveRestaunt(Guid userId, Restaunt restaunt);

    }
}
