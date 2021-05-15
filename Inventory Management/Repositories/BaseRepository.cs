using Inventory_Management.Entities;
using Inventory_Managment.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment.Repositories
{
    abstract class BaseRepository<T>
    {
        protected DBConnection _dbConnection;
        protected string tableName;

        public BaseRepository()
        {
            _dbConnection = DBConnection.Instance();
        }

        public abstract T GetOne(int id);

        public abstract List<T> GetAll();

        public abstract void Insert(T entity);

        public abstract void Update(int id, T entity);

        public abstract void Delete(int id);
    }
}
