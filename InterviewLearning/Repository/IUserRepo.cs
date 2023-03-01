using InterviewLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Repository
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUser();
        User loginUser(string email, string password);
        string saveUser(User user);

    }
}
