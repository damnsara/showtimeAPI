﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Showtime.Domain.Entities;
using Showtime.Domain.Interfaces;
using Showtime.Infra.Data.Contexts;

namespace Showtime.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SQLContext _sqlContext;

        public BaseRepository(SQLContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Select(id));
            _sqlContext.SaveChanges();
        }

        public void Insert(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
            _sqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }

        public IList<TEntity> Select() => _sqlContext.Set<TEntity>().ToList();
        

        public TEntity Select(int id) => _sqlContext.Set<TEntity>().Find(id);


    }

}
