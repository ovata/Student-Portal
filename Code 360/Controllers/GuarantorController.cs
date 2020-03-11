using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code_360.Models.Guarantor;
using Code_360.Models.Interface;
using Code_360.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Code_360.Controllers
{
    public class GuarantorController : Controller 
    {
        private readonly IGuarantor _guarantorRepository;

        public GuarantorController(IGuarantor guarantorRepository)
        {
            _guarantorRepository = guarantorRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AddGuarantor()
        {
            return View();
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
                _guarantorRepository.AddGuarantor(newGuarantor);
            }
            return View();
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
                Nationality = guarantor.Nationality
            };
            return View(update);
        }

        public ViewResult GuarantorDetails()
        {
            var model = _guarantorRepository.GetGuarantors();

            GuarantorDetailsViewModel guarantorDetailsViewModel = new GuarantorDetailsViewModel
            {
                GetGuarantors = model.ToList()
            };
            return View(guarantorDetailsViewModel);
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
