using InterviewLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Services
{
    public interface IMenuService
    {

        string AddMenuForRestaunt(Guid RestauntId, Menu menu);
        string DeleteMenuForRestaunt(Guid menuId);
        IEnumerable<Menu> RestauntMenuList(Guid restauntId);
    }
}
