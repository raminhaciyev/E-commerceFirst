using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface INewUserService
    {
        void AddUser(NewUser newUser);
        void DeleteUser(NewUser newUser);
        void UpdateUser(NewUser newUser);
        List<NewUser> GetAllList();
        NewUser GetById(int id);
    }
}
