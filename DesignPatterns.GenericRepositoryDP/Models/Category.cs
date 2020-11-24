using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GenericRepositoryDP.Models
{
    public interface ICoreEntity { }

    public abstract class CoreEntity:ICoreEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class Category :CoreEntity
    {        
        public string CategoryName { get; set; }
        public string Description { get; set; }        
    }

    public class Shipper : CoreEntity
    {        
        public string CompanyName { get; set; }
        public string Phone { get; set; }        
    }

}
