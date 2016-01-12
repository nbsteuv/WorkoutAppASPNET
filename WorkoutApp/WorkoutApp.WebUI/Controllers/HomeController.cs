using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutApp.Model;
using WorkoutApp.Sessions.Repositories;

namespace WorkoutApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryBase<Exercise> exercises;
        IRepositoryBase<ExerciseSet> exerciseSets;
        IRepositoryBase<WorkoutSession> workoutSessions;

        public HomeController(IRepositoryBase<Exercise> exercises, IRepositoryBase<ExerciseSet> exerciseSets, IRepositoryBase<WorkoutSession> workoutSessions)
        {
            this.exercises = exercises;
            this.exerciseSets = exerciseSets;
            this.workoutSessions = workoutSessions;
        }

        public ActionResult TestRepositories()
        {
            string exerciseTestResult = exercises.Test();
            string exerciseSetTestResult = exerciseSets.Test();
            string workoutSessionTestResult = workoutSessions.Test();

            ViewBag.exerciseTestResult = exerciseTestResult;
            ViewBag.exerciseSetTestResult = exerciseSetTestResult;
            ViewBag.workoutSessionTestResult = workoutSessionTestResult;

            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}