using InterviewLearning.Data;
using InterviewLearning.Models;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Repository
{
    [EnableCors("CorsPolicy")]
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _db;

        public UserRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<User> GetAllUser()
        {
            return _db.users;
        }

        public User loginUser(string email, string password)
        {
            var user = _db.users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower() &&
                                                u.Password.ToLower() == password.ToLower());
            return user;
        }

        public string saveUser(User user)
        {
            var newUser = _db.users.FirstOrDefault(u => u.Email == user.Email);
            if (newUser == null)
            {
                _db.users.AddAsync(user);
                _db.SaveChangesAsync();
                return "user Successfully added.";

            }
            else
                return "Email is used pls Enter Diffrent Emails";

        }
    }
}
