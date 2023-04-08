using InterviewLearning.Data;
using InterviewLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLearning.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly ApplicationDbContext _db;

        public MenuRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public string AddMenuForRestaunt(Guid RestauntId, Menu menu)
        {
            var restaunt = _db.restaunts.FirstOrDefault(res => res.Id == RestauntId);
            menu.Restaunt = restaunt;
            menu.RestauntId = RestauntId;
            _db.menus.Add(menu);
            _db.SaveChanges();
            return "Added Successfully";
        }

        public string DeleteMenuForRestaunt(Guid menuId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> RestauntMenuList(Guid restauntId)
        {
            return _db.menus
                    .Where(menu => (menu.IsAvailable) 
                    && (menu.RestauntId == restauntId));
        }
    }
}