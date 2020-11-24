using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RepositoryDP.Services
{
    using DesignPatterns.RepositoryDP.Models;
    using Models;
    using Repositories;

    public class CategoryRepository : IRepository
    {
        public Category Add(Category category)
        {
            return category;
        }

        public Category Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category category)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            return 0;
        }
    }
}
