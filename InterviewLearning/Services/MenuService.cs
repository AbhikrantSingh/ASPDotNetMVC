using InterviewLearning.Models;
using InterviewLearning.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepo;

        public MenuService(IMenuRepository menuRepo)
        {
            _menuRepo = menuRepo;
        }

        public string AddMenuForRestaunt(Guid RestauntId, Menu menu)
        {
            return _menuRepo.AddMenuForRestaunt(RestauntId, menu);
        }

        public string DeleteMenuForRestaunt(Guid menuId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> RestauntMenuList(Guid restauntId)
        {
            return _menuRepo.RestauntMenuList(restauntId);
        }
    }
}
