using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model;

namespace Oregon.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(Expression<Func<T, bool>> expression);

        IQueryable<T> GetMany(Expression<Func<T, bool>> expression);

        void Insert(T obj);

        void Update(T obj);

        TeamProfileModel GetById(int id);

        int Count();

        void Save();

    }
}
