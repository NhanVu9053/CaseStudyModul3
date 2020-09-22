using BookHouse.Models.EF;
using BookHouse.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Repositories
{
    public class OrderRepositories : IOrderRepositories
    {
        private readonly AppDBContext context;

        public OrderRepositories(AppDBContext context)
        {
            this.context = context;
        }
        public Order Create(Order order)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order Edit(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> Get()
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
