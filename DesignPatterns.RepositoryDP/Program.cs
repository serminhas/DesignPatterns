using System;

namespace DesignPatterns.RepositoryDP
{
    using Services;
    using Repositories;
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            IRepository _categoryservice = new CategoryRepository();

           
            var category= _categoryservice.Add(new Category { CategoryName = "Beverages", Description = "Soft, Tea" });

            var deleteCategory = _categoryservice.GetById(1);
            _categoryservice.Delete(deleteCategory);
        }
    }
}
