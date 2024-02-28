using Microsoft.EntityFrameworkCore;
using Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public partial interface IDbContext
    {
        #region Methods
        void DeleteEntity<TEntity>(TEntity entity) where TEntity : BaseEntity;
        void InsertEntity<TEntity>(TEntity entity) where TEntity:BaseEntity;
        void UpdateEntity<TEntity>(TEntity entity)where TEntity:BaseEntity;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;   
        DbSet<TEntity> SetModel<TEntity>() where TEntity : BaseEntity;
        IQueryable<TEntity> EntityFromSql<TEntity>(string sql,params object[] parameters) where TEntity : BaseEntity;

        #endregion
    }
}
