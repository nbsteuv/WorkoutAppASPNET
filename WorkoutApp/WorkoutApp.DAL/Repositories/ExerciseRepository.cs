using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.DAL.Data;
using WorkoutApp.Model;

namespace WorkoutApp.DAL.Repositories
{
    public class ExerciseRepository : RepositoryBase<Exercise>
    {
        public ExerciseRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }

    }
}
