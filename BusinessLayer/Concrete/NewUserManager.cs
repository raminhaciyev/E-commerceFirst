using BusinessLayer.Abstract;
using DataAccessLayer.Abstact;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewUserManager : INewUserService
    {
        INewUserDal _newUserDal;

        public NewUserManager(INewUserDal newUserDal)
        {
            _newUserDal = newUserDal;
        }

        public void AddUser(NewUser newUser)
        {
            _newUserDal.Insert(newUser);
        }

        public void DeleteUser(NewUser newUser)
        {
            throw new NotImplementedException();
        }

        public List<NewUser> GetAllList()
        {
            return _newUserDal.GetAllList();
        }

        public NewUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(NewUser newUser)
        {
            throw new NotImplementedException();
        }
    }
}
