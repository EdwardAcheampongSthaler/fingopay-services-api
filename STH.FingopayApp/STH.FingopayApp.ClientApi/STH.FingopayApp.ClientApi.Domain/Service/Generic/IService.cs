using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace STH.FingopayApp.ClientApi.Domain.Service.Generic
{
    public interface IService<Tv, Te>
    {
        IEnumerable<Tv> GetAll();
        Guid Add(Tv obj);
        bool Update(Tv obj);
        bool Remove(Guid id);
        Tv GetOne(Guid id);
        IEnumerable<Tv> Get(Expression<Func<Te, bool>> predicate);
    }
}
