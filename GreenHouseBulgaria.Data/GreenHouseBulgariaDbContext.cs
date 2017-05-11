using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using GreenHouseBulgaria.Models;

namespace GreenHouseBulgaria.Data
{
    public class GreenHouseBulgariaDbContext : IdentityDbContext<User>, IGreenHouseBulgariaDbContext
    {
        public GreenHouseBulgariaDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Service> Services { get; set; }

        public virtual IDbSet<Subscription> Subscriptions { get; set; }

        public virtual IDbSet<ContactMessage> ContactMessages { get; set; }


        public static GreenHouseBulgariaDbContext Create()
        {
            return new GreenHouseBulgariaDbContext();
        }

        IDbSet<TEntity> IGreenHouseBulgariaDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasOptional(ser => ser.Image).WithRequired(img => img.Service);

            base.OnModelCreating(modelBuilder);
        }
    }
}
