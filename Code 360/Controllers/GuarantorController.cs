using Code_360.Interface;
using Code_360.Models;
using Code_360.Models.Guarantor;
using Code_360.Models.Interface;
using Code_360.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Code_360.Controllers
{
    public class GuarantorController : Controller
    {
        private readonly IGuarantor _guarantorRepository;
        private readonly IStudentGuarantor _studentGuarantor;

        public GuarantorController(IGuarantor guarantorRepository, IStudentGuarantor studentGuarantor)
        {
            _guarantorRepository = guarantorRepository;
            _studentGuarantor = studentGuarantor;
        }

        [HttpGet]
        public ViewResult AddGuarantor(Guid? Id)
        {
            GuarantorViewModel guarantor = new GuarantorViewModel();
            if (Id != null)
            {
                guarantor.StudentId = Id.Value;
            };
            return View(guarantor);
        }

        [HttpPost]
        public IActionResult AddGuarantor(GuarantorViewModel guarantorModel)
        {
            if (ModelState.IsValid)
            {
                Guarantor newGuarantor = new Guarantor
                {
                    Name = guarantorModel.Name,
                    Address = guarantorModel.Address,
                    Number = guarantorModel.Number,
                    Gender = guarantorModel.Gender,
                    Relationship = guarantorModel.Relationship,
                    Occupation = guarantorModel.Occupation,
                    Email = guarantorModel.Email,
                    Nationality = guarantorModel.Nationality
                };
                var model = _guarantorRepository.AddGuarantor(newGuarantor);
                StudentGuarantor studentGuarantor = new StudentGuarantor
                {
                    StudentId = guarantorModel.StudentId,
                    GuarantorId = model.Id
                };
                _studentGuarantor.AddStdGtr(studentGuarantor);
                return RedirectToAction("studentinfo", "home", new { id = guarantorModel.StudentId });
            }
            return View(guarantorModel);
        }

        [HttpPost]
        public IActionResult EditGuarantor(UpdateGuarantor updateGuarantor)
        {
            if (ModelState.IsValid)
            {
                Guarantor guarantor = _guarantorRepository.GetGuarantor(updateGuarantor.Id);
                guarantor.Name = updateGuarantor.Name;
                guarantor.Number = updateGuarantor.Number;
                guarantor.Gender = updateGuarantor.Gender;
                guarantor.Address = updateGuarantor.Address;
                guarantor.Relationship = updateGuarantor.Relationship;
                guarantor.Occupation = updateGuarantor.Occupation;
                guarantor.Email = updateGuarantor.Email;
                guarantor.Nationality = updateGuarantor.Nationality;

                _guarantorRepository.UpdateGuarantor(guarantor);
            }
            return View();
        }

        [HttpGet]
        public ViewResult EditGuarantor(Guid Id)
        {
            Guarantor guarantor = _guarantorRepository.GetGuarantor(Id);
            UpdateGuarantor update = new UpdateGuarantor
            {
                Id = guarantor.Id,
                Name = guarantor.Name,
                Number = guarantor.Number,
                Gender = guarantor.Gender,
                Relationship = guarantor.Relationship,
                Occupation = guarantor.Occupation,
                Email = guarantor.Email,
                Nationality = guarantor.Nationality,
                Address = guarantor.Address
            };
            return View(update);
        }

        public ViewResult GuarantorDetails()
        {
            var model = _guarantorRepository.GetGuarantors();

            AllModelsViewModel allModelsViewModel = new AllModelsViewModel
            {
                AllGuarantors = model.ToList()
            };
            return View(allModelsViewModel);
        }

        public ViewResult GuarantorInfo(Guid? Id)
        {
            Guarantor guarantor = _guarantorRepository.GetGuarantor(Id.Value);
            if (guarantor == null)
            {
                Response.StatusCode = 404;
            }
            GuarantorDetailsViewModel guarantorDetailsViewModel = new GuarantorDetailsViewModel
            {
                Guarantor = guarantor,
                PageTitle = "Guarantor Details"
            };
            return View(guarantorDetailsViewModel);
        }
    }
}
