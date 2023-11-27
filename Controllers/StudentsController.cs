using Microsoft.AspNetCore.Mvc;
using StudentGradeBookSystem.Models;
using System.Diagnostics;


namespace StudentGradeBookSystem.Controllers
{
    public class StudentsController : Controller
    {

        public static List<Student> students = new List<Student>();

        public ActionResult Index()
        {
                return View();            
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student e)
        {
            if (ModelState.IsValid == true)
            {
                students.Add(e);
            }
            return View("ListOfStudents", students);
        }

        public ActionResult ListOfStudents(Student sg)
        {
            return View("ListOfStudents", students);
        }

        
        public ActionResult Delete(string name)
        {
            
            Student st = students.Find(x => x.Name == name);
            students.Remove(st);

            return View("ListOfStudents", students);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string name)
        {
            
            return View("ListOfStudents", students.Where(x => x.Name.Contains(name)));

        }
    }
}
