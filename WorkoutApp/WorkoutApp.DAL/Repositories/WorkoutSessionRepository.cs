using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutApp.DAL.Data;
using WorkoutApp.Model;

namespace WorkoutApp.DAL.Repositories
{
    public class WorkoutSessionRepository<TEntity> where TEntity : class
    {

        internal DataContext context;
        internal DbSet<TEntity> dbSet;

        public WorkoutSessionRepository(DataContext context)
        {
            if (context == null)
                throw new ArgumentNullException();

            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual string Test()
        {
            return ("Repository test method for " + context + " successful.");
        }

        public virtual void CreateExercise(string muscleGroup, string exerciseName, int weight, int reps)
        {
            Exercise newExercise = new Exercise();
            newExercise.MuscleGroup = muscleGroup;
            newExercise.ExerciseName = exerciseName;
            ExerciseSet newExerciseSet = new ExerciseSet();
            newExerciseSet.ExerciseSetWeight = weight;
            newExerciseSet.ExerciseSetReps = reps;
            newExercise.ExerciseSetList.Add(newExerciseSet);
        }

    }
}
