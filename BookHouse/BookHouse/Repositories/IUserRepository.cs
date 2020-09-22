
using BookHouse.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Repositories
{
  public  interface IUserRepository
    {
        IEnumerable<User> Get();

        User Get(int id);

        User Create(User product);

        User Edit(User product);

        bool Delete(int id);
    }
}
