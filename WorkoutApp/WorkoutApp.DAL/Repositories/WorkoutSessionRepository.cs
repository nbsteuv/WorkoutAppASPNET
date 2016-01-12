using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.DAL.Data;
using WorkoutApp.Model;

namespace WorkoutApp.DAL.Repositories
{
    public class WorkoutSessionRepository : RepositoryBase<WorkoutSession>
    {
        public WorkoutSessionRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }

    }
}
