using WorkoutApp.Sessions.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.DAL.Data;

namespace WorkoutApp.DAL.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        //I'm not completely clear here, so I'll have some questions if I don't find the answers in my reading by our first code review.

        internal DataContext context;
        internal DbSet<TEntity> dbSet;

        public RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual string Test()
        {
            return ("Repository test method for " + context + " successful.") ;
        }

    }
}
