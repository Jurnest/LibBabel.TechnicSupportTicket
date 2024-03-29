﻿using LibBabel.TechnicSupportTicket.Domain.Models;
using System.Linq.Expressions;

namespace LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;

public interface IGenericRepository<TEntity> where TEntity : BaseModel
{
    Task<int> AddAsync(TEntity entity);
    Task<int> AddAsync(IEnumerable<TEntity> entities);
    int Add(TEntity entity);
    int Add(IEnumerable<TEntity> entities);

    Task<int> UpdateAsync(TEntity entity);
    int Update(TEntity entity);

    Task<int> DeleteAsync(TEntity entity);
    Task<int> DeleteAsync(int id);
    Task<bool> DeleteRangeAsync(Expression<Func<TEntity, bool>> predicate);
    int Delete(TEntity entity);
    int Delete(int id);
    bool DeleteRange(Expression<Func<TEntity, bool>> predicate);

    Task<int> AddOrUpdateAsync(TEntity entity);
    int AddOrUpdate(TEntity entity);

    IQueryable<TEntity> AsQuerayable();

    Task<List<TEntity>> GetAll(bool noTracking = true);
    Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate, bool noTracking = true, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes);
    Task<TEntity> GetByIdAsync(int id, bool noTracking = true, params Expression<Func<TEntity, object>>[] includes);
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate, bool noTracink = true, params Expression<Func<TEntity, object>>[] includes);
    Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool noTracking = true, params Expression<Func<TEntity, object>>[] includes);
    IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, bool noTracinkg = true, params Expression<Func<TEntity, object>>[] includes);

    Task BulkDeleteById(IEnumerable<int> ids);
    Task BulkDelete(Expression<Func<TEntity, bool>> predicate);
    Task BulkDelete(IEnumerable<TEntity> entities);
    Task BulkUpdate(IEnumerable<TEntity> entities);
    Task BulkAdd(IEnumerable<TEntity> entities);
}
