using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        T GetById(int id);
        void Add(T entity);
        void Remove(int id);
        void Update(T entity);
        IEnumerable<T> GetAll();

    }
}
