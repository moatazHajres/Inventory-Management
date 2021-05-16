using Inventory_Management.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Repositories
{
    // Repository pattern
    abstract class BaseRepository<E>
    {
        protected DBConnection _dbConnection;

        public BaseRepository()
        {
            _dbConnection = DBConnection.Instance();
        }

        public abstract E GetOne(int id);

        public abstract List<E> GetAll();

        public abstract void Insert(E entity);

        public abstract void Update(int id, E entity);

        public abstract void Delete(int id);
    }
}
