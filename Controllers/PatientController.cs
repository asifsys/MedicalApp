using Microsoft.AspNetCore.Mvc;
using MedicalApp.Models;
using MedicalApp.Data;

namespace MedicalApp.Controllers
{
    public class PatientController : Controller
    {
        private readonly AppDbContext _context;

        public PatientController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Patients.Add(patient);
                _context.SaveChanges();

                ViewBag.Message = "Patient Saved Successfully";
            }

            return View();
        }
    }
}
