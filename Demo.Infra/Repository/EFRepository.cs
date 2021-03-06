﻿using Demo.Domain.Interfaces.Repository;
using Demo.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Infra.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext _dbContext;

        public EFRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public virtual TEntity Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        
        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
