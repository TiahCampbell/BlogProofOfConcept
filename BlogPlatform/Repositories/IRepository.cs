using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using blog_template_practice.Extensions;

namespace blog_template_practice.Repositories
{
    public interface IRepository<T> : ISelectList where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(T obj);
        void Update(T obj);
    }
}
