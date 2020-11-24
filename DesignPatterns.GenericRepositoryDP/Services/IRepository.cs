using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GenericRepositoryDP.Services
{
    using Models;
    using Services;
    public interface IRepository<T> where T:ICoreEntity
    {
        public void Add(T item);
        public void Delete(T item);
        public void Update(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();

    }

    public interface ICategoryRepository: IRepository<Category>
    {
        void UpdateAllCategories();
    }

    public interface IShipperRepository: IRepository<Shipper>
    {
      
    }

    public interface IProductRepository : IRepository<Product>
    {

    }
}
