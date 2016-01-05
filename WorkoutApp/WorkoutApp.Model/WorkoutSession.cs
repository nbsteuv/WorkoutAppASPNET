using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.Model
{
    public class WorkoutSession
    {
        public int WorkoutSessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public ICollection<Exercise> SessionExerciseList { get; set; }

    }
}
