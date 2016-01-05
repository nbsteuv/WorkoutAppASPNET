using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.Model
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string MuscleGroup { get; set; }
        public string ExerciseName { get; set; }
        public ICollection<ExerciseSet> ExerciseSetList { get; set; }
    }
}
