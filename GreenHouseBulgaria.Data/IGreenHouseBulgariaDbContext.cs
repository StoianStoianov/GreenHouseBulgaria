using GreenHouseBulgaria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Data
{
    public interface IGreenHouseBulgariaDbContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Service> Services { get; set; }

        IDbSet<Subscription> Subscriptions { get; set; }
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}
