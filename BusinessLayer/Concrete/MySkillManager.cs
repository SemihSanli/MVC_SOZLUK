using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MySkillManager
    {
        GenericRepository<MySkill> repo=new GenericRepository<MySkill>();

        public List<MySkill> GetAll()
        {
            return repo.List();
        }
    }
}
