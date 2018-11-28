using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace STH.FingopayApp.ClientApi.Domain.Service.Generic
{
    public interface IServiceAsync<Tv, Te>
    {
        Task<IEnumerable<Tv>> GetAll();
        Task<Guid> Add(Tv obj);
        Task<bool> Update(Tv obj);
        Task<bool> Remove(Guid id);
        Task<Tv> GetOne(Guid id);
        Task<IEnumerable<Tv>> Get(Expression<Func<Te, bool>> predicate);
    }

}
