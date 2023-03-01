using InterviewLearning.Models;
using InterviewLearning.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo userRepo;

        public UserService(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }

        public IEnumerable<User> GetAllUser()
        {
            return userRepo.GetAllUser();
        }

        public User loginUser(string email, string password)
        {
           return userRepo.loginUser(email,password);
        }

        public string saveUser(User user)
        {
            return userRepo.saveUser(user);
        }
    }
}
