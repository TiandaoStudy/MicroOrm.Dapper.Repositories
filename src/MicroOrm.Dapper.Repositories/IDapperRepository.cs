﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MicroOrm.Dapper.Repositories
{
    public interface IDapperRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll();

        Task<IEnumerable<TEntity>> FindAllAsync();

        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression);

        Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> expression);

        IEnumerable<TEntity> FindAll<TChild1>(Expression<Func<TEntity, object>> tChild1);

        Task<IEnumerable<TEntity>> FindAllAsync<TChild1>(Expression<Func<TEntity, object>> tChild1);

        IEnumerable<TEntity> FindAll<TChild1>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>> tChild1);

        Task<IEnumerable<TEntity>> FindAllAsync<TChild1>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>> tChild1);

        TEntity Find(Expression<Func<TEntity, bool>> expression);

        TEntity Find<TChild1>(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>> tChild1);

        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> expression);

        bool Insert(TEntity instance);

        Task<bool> InsertAsync(TEntity instance);

        bool Delete(TEntity instance);

        Task<bool> DeleteAsync(TEntity instance);

        bool Update(TEntity instance);

        Task<bool> UpdateAsync(TEntity instance);

    }
}