using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GenericRepositoryDP.Services
{
    using DesignPatterns.GenericRepositoryDP.Models;
    using Models;

    public class CoreService<T> : IRepository<T> where T:ICoreEntity
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryService : CoreService<Category>, ICategoryRepository
    {
        public void UpdateAllCategories()
        {
            throw new NotImplementedException();
        }
    }
    public class ShipperService : CoreService<Shipper>, IShipperRepository
    {
        
    }

    //public class HelperService: CoreService<Helper>
    //{

    //}

    //public struct Helper 
    //{
    //    public void Clear()
    //    {

    //    }
    //    public string ClearUrl(string param)
    //    {
    //        return param;
    //    }


    
    //}
}
