﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Showtime.Domain.Entities;
namespace Showtime.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);
        
        void Delete(int id);

        IList<TEntity> Select();
        
        TEntity Select(int id);
  
    }
}
