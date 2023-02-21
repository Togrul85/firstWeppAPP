using Microsoft.AspNetCore.Mvc;
using P326FirstWeppApp.Models;
using P326FirstWeppApp.ViewModels;
using System.Collections.Generic;

namespace P326FirstWeppApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Ismayil";
            ViewBag.Surname = GetStudents();
            TempData["Age"] = 20;
            //return File("~/image/lorem.jpg","image/ppg");
            //var groups = GetGrouops();
            //var students = GetStudents();
            //HomeVm homeVm  = new HomeVm();
            //homeVm.Students = GetStudents();
            //homeVm.Groups = groups;
           // return RedirectToAction("About","test");
           return View();
        

        }

        public IActionResult About()
        {
            return View();   
        }

        private List<Student> GetStudents()
        {
            List<Student> students =new List<Student>();
            students.Add(new Student() { Id =1,Name="Toghrul",Surname="Salmanzade"});
            students.Add(new Student() { Id = 2, Name = "Stu2", Surname = "Sur2" });
            students.Add(new Student() { Id = 3, Name = "Stu3", Surname = "Sur3" });
          return students;
        }


        private List<Group> GetGrouops()
        {
            List<Group> groups = new List<Group>();
            groups.Add(new Group() { Id = 1, Name = "Grp1"  });
            groups.Add(new Group() { Id = 2, Name = "Grp2" });
            groups.Add(new Group() { Id = 3, Name = "Grp3" });
            return groups;
        }
    }
}
