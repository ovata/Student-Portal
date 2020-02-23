using Code_360.Models;
using Code_360.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IStudentRepository studentRepository, IHostingEnvironment hostingEnvironment)
        {
            _studentRepository = studentRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        [Route("")]
        [Route("/home")]
        [Route("/index")]
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
        public IActionResult Create(StudentViewModel studentModel)
        {
            if (ModelState.IsValid)
            {
                string fileName = null;
                if (studentModel != null)
                {
                    string UploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    fileName = Guid.NewGuid().ToString() + "_" + studentModel.Photo.FileName;
                    string filePath= Path.Combine(UploadFolder, fileName);
                    studentModel.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Student newStudent = new Student
                {
                    Name = studentModel.Name,
                    Gender = studentModel.Gender,
                    DateOfBirth = studentModel.DateOfBirth,
                    Address = studentModel.Address,
                    Nationality = studentModel.Nationality,
                    Phone = studentModel.Phone,
                    Photo = fileName,
                    MaritalStatus = studentModel.MaritalStatus,
                    AddmissionType = studentModel.AddmissionType,
                    NextOfKinName = studentModel.NextOfKinName,
                    NextOfKinEmail = studentModel.NextOfKinEmail,
                    NextOfKinPhone = studentModel.NextOfKinPhone,
                    NextOfKinDocumentUrl = studentModel.NextOfKinDocumentUrl,
                    BVN = studentModel.BVN
                };
                _studentRepository.AddStudent(newStudent);
                return RedirectToAction("index", new { Id = newStudent.Id });
            }
            return View();
        }

        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _studentRepository.RemoveStudent(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Student student = _studentRepository.GetStudent(id);
            UpdateStudent update = new UpdateStudent
            {
                Id = student.Id,
                Name = student.Name,
                Gender = student.Gender,
                DateOfBirth = student.DateOfBirth,
                Address = student.Address,
                Nationality = student.Nationality,
                ExistingPhotoPath = student.Photo,
                MaritalStatus = student.MaritalStatus,
                AddmissionType = student.AddmissionType,
                NextOfKinName = student.NextOfKinName,
                NextOfKinEmail = student.NextOfKinEmail,
                NextOfKinPhone = student.NextOfKinPhone,
                NextOfKinDocumentUrl = student.NextOfKinDocumentUrl,
                BVN = student.BVN
            };
            return View(update);
        }

    }
}
