using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.Sessions.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Test();
    }
}
