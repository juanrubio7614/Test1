using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Test1.DataAccess.Interfaces;
using Test1.Library.Interfaces;
using Test1.Managers.Interfaces;

namespace Test1.Managers
{
    public abstract class BaseManager<TEntity> : IBaseManager<TEntity> where TEntity : DataEntity
    {
        protected readonly IRepository<TEntity> Repository;
        // protected readonly IObjectCache Cache;
        protected readonly bool HasCache;
        protected object CacheLock;
        protected BaseManager(IRepository<TEntity> repository)
        {
            Repository = repository;
            //  Cache = null;
            CacheLock = null;
        }

      

        public TEntity Get(object[] keys)
        {
            //    if (!HasCache) return Repository.Get(keys);
            //    var itemCacheKey = GetCacheKey(keys);
            //    lock (CacheLock)
            //    {
            //        if (Cache.Exists<TEntity>(itemCacheKey))
            //        {
            //            return Cache.Get<TEntity>(itemCacheKey);
            //        }
            //    }
            var tEntity = Repository.Get(keys);
            //    lock (CacheLock)
            //    {
            //        if (Cache.Exists<TEntity>(itemCacheKey))
            //        {
            //            return Cache.Get<TEntity>(itemCacheKey);
            //        }
            //        else
            //        {
            //            Cache.AddAbsolute(tEntity, itemCacheKey, TimeSpan.FromMinutes(5));

            //        }
            //    }
            return tEntity;
        }
        public List<TEntity> Find(Expression<Func<TEntity, bool>> predicate, int pageIndex = 0, int pageSize = 50)
        {
            return Repository.Find(predicate, pageIndex, pageSize).ToList();
        }

        public List<TEntity> GetAll(int pageIndex = 0, int pageSize = 50)
        {
            var allFound = Repository.GetAll(pageIndex, pageSize);
            return allFound;
        }

        public int Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Remove(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public int SaveNew(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int SaveNew(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
