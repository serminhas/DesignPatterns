using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RepositoryDP.Repositories
{
    using Models;

    public interface IRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="category">Category nesnesi teslim ediniz</param>
        /// <returns>Category</returns>
        
        Category Add(Category category);

        Category Delete(Category category);
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        bool Update(Category category);
        int Save();
    }
}
