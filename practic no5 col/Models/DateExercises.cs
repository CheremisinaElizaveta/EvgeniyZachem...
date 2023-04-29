using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_no5_col
{
    public class DateExercises
    {
        public static Dictionary<DateTime, DateExercises> data = new Dictionary<DateTime, DateExercises>();
        public DateTime Date { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
        public Exercise frontFood = null;

        public DateExercises(DateTime date, List<Exercise> exercises)
        {
            Date = date;
            Exercises = exercises;
        }
    }
}
