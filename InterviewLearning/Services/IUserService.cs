using InterviewLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUser();
        User loginUser(string email, string password);
        string saveUser(User user);

    }
}
