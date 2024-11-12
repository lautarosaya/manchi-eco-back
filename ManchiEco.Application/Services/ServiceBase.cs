using ManchiEco.Application.Interfaces;
using ManchiEco.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchiEco.Application.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected readonly IRepositoryBase<T> _repositoryBase;
        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Add(T entity)
        {
            _repositoryBase.Add(entity);
        }
        public void Remove(int id)
        {
            _repositoryBase.Remove(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }
        public T GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }
        public void Update(T entity)
        {
            _repositoryBase.Update(entity);
        }
    }
}
