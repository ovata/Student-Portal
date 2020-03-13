using Code_360.Interface;
using Code_360.Models;
using Code_360.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace Code_360.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IStudentGuarantor _sgRepo;

        public HomeController(IStudentRepository studentRepository, IHostingEnvironment hostingEnvironment, IStudentGuarantor studentGuarantor)
        {
            _studentRepository = studentRepository;
            this.hostingEnvironment = hostingEnvironment;
            _sgRepo = studentGuarantor;
        }

        [Route("")]
        [Route("/home")]
        [Route("/index")]
        [AllowAnonymous]
        public ViewResult Index()
        {
            var model = _studentRepository.GetAllStudent();
            return View(model);
        }

        [AllowAnonymous]
        public ViewResult StudentDetails()
        {
            var model = _studentRepository.GetAllStudent();

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel
            {
                GetStudents = model.ToList()
            };

            return View(homeDetailsViewModel);
        }

        [AllowAnonymous]
        public ViewResult StudentInfo(Guid? id)
        {
            Student student = _studentRepository.GetStudent(id.Value);
            if (student == null)
            {
                Response.StatusCode = 404;
                return View("StudentNotFound", id.Value);
            }

            var studentGuarantors = _sgRepo.GetStudentGuarantor(id.Value).ToList();
            AllModelsViewModel allModelsViewModel = new AllModelsViewModel
            {
                Student = student,
                GetGuarantors = studentGuarantors,
                PageTitle = "Student Details"
            };
            return View(allModelsViewModel);
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
                string fileName = ProcessUploadedFile(studentModel);
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
                return RedirectToAction("studentinfo", new { Id = newStudent.Id });
            }
            return View();
        }

        [HttpGet]
        public ViewResult Edit(Guid Id)
        {
            Student student = _studentRepository.GetStudent(Id);
            UpdateStudent update = new UpdateStudent
            {
                Id = student.Id,
                Name = student.Name,
                Gender = student.Gender,
                DateOfBirth = student.DateOfBirth,
                Address = student.Address,
                Nationality = student.Nationality,
                Phone = student.Phone,
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

        [HttpPost]
        public IActionResult Edit(UpdateStudent studentModel)
        {
            if (ModelState.IsValid)
            {
                Student student = _studentRepository.GetStudent(studentModel.Id);
                student.Name = studentModel.Name;
                student.Gender = studentModel.Gender;
                student.DateOfBirth = studentModel.DateOfBirth;
                student.Nationality = studentModel.Nationality;
                student.Phone = studentModel.Phone;
                student.MaritalStatus = studentModel.MaritalStatus;
                student.AddmissionType = studentModel.AddmissionType;
                student.NextOfKinName = studentModel.NextOfKinName;
                student.NextOfKinEmail = studentModel.NextOfKinEmail;
                student.NextOfKinPhone = studentModel.NextOfKinPhone;
                student.NextOfKinDocumentUrl = studentModel.NextOfKinDocumentUrl;
                student.BVN = studentModel.BVN;
                if (studentModel.Photo != null)
                {
                    if (studentModel.ExistingPhotoPath != null)
                    {
                        string filepath = Path.Combine(hostingEnvironment.WebRootPath, "images", studentModel.ExistingPhotoPath);
                        System.IO.File.Delete(filepath);
                    }
                    student.Photo = ProcessUploadedFile(studentModel);
                }

                _studentRepository.UpdateStudent(student);
                return RedirectToAction("index");
            }
            return View();
        }

        [Route("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            _studentRepository.RemoveStudent(id);
            return RedirectToAction("Index");
        }

        private string ProcessUploadedFile(StudentViewModel studentModel)
        {
            string fileName = null;
            if (studentModel != null)
            {
                string UploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "_" + studentModel.Photo.FileName;
                string filePath = Path.Combine(UploadFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    studentModel.Photo.CopyTo(fileStream);
                }
            }

            return fileName;
        }
    }
}
