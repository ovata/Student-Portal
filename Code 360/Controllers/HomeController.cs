using Code_360.Models;
using Code_360.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [Route("")]
        public ViewResult Index()
        {
            var model = _studentRepository.GetAllStudent();
            return View(model);
        }

        public ViewResult Student_Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel
            {
                Student = _studentRepository.GetStudent(id ?? 1),
                PageTitle = "Student Details"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            Student newStund = _studentRepository.AddStudent(student);
            return RedirectToAction("index", new { Id = newStund.Id });
        }

        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _studentRepository.RemoveStudent(id);
            return RedirectToAction("Index");
        }
        
        [Route("Update")]
        public ViewResult UpdateStudent(int id)
        {
            Student student = _studentRepository.GetStudent(id);
            UpdateStudent update = new UpdateStudent()
            {
                Name = student.Name,
                Gender = student.Gender
            };
            return View(update);
        }

    }
}
