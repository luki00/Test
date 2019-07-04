using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Repos;
using Domain.ViewModels;


namespace Test.Controllers
{
    public class HospitalsController : Controller
    {
        IHospitalsRepo hospitalsRepo;

        public HospitalsController()
        {
            hospitalsRepo = new HospitalsRepo();
        }
        // GET: Hospitals
        public ActionResult Index()
        {
            return View(hospitalsRepo.GetHospitalsList());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View(hospitalsRepo.GetHospitalEdit(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HospitalsViewModel hospital)
        {
            hospitalsRepo.EditHospital(hospital.Edit);

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HospitalsViewModel hospital)
        {
            hospitalsRepo.CreateHospital(hospital.Create);

            return RedirectToAction("Index");
        }




        public ActionResult Details(int id)
        {
            return View(hospitalsRepo.GetHospitalDetails(id));
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            hospitalsRepo.DeleteHospital(id);
            return RedirectToAction("Index");
        }

    }
}