using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutApp.DAL.Repositories;
using WorkoutApp.Model;

namespace WorkoutApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        WorkoutSessionRepository<WorkoutSession> workoutSessions;
        WorkoutSessionRepository<Exercise> exercises;
        WorkoutSessionRepository<ExerciseSet> exerciseSets;

        public HomeController()
        {
        }

        public ActionResult TestRepositories()
        {
            return View();
        }

        public ActionResult AddExercise()
        {
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