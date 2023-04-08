using InterviewLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Repository
{
    public interface IMenuRepository
    {
        string AddMenuForRestaunt(Guid RestauntId, Menu menu);
        string DeleteMenuForRestaunt(Guid menuId);
        IEnumerable<Menu> RestauntMenuList(Guid restauntId);

    }
}