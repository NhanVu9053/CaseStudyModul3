using BookHouse.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Repositories
{
    public interface IOrderRepositories
    {
        IEnumerable<Order> Get();

        Order Get(int id);

        Order Create(Order order);

        Order Edit(Order order);

        bool Delete(int id);
    }
}
