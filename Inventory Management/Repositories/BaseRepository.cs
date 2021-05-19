using Inventory_Management.Database;
using Inventory_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Repositories
{
    // Repository pattern
    abstract class BaseRepository<EntityType> where EntityType : BaseEntity
    {
        protected DBConnection _dbConnection;

        public BaseRepository()
        {
            _dbConnection = DBConnection.Instance();
        }

        public abstract EntityType Find(int id);

        public abstract List<EntityType> All();

        public abstract void Insert(EntityType entity);

        public abstract void Update(int id, EntityType entity);

        public abstract void Delete(int id);

        public abstract List<EntityType> SearchBy(string value, string key, string op);

        // public abstract List<EntityType> SearchAll(string keyword);
    }
}
