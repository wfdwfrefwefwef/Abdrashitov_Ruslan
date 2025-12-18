using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentAccounting.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T? GetById(int id);

        void Add(T entity);

        void Remove(T entity);

        void Save();
    }
}
