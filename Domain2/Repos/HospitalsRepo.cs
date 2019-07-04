using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Identity;

using Test.Models;

namespace Domain.Repos
{
    public class HospitalsRepo : IHospitalsRepo
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public HospitalsViewModel GetHospitalsList()
        {
            List<HospitalsGetViewModel> Lista;

            if (true)
            {
                Lista = db.Hospitals.Select(e => new HospitalsGetViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Describtion = e.SorDescribtion,
                    Active = e.Active
                }).ToList();
                }
            else
            {
                Lista = db.Hospitals.Where(r => r.Active == true).Select(e => new HospitalsGetViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Describtion = e.SorDescribtion,
                    Active = e.Active
                }).ToList();
            }

            return new HospitalsViewModel
            {
                List = Lista
            };
        }

        public HospitalsViewModel GetHospitalDetails(int id)
        {

            return new HospitalsViewModel
            {
                Details = db.Hospitals.Select(e => new HospitalsGetViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Describtion = e.SorDescribtion,
                    Active = e.Active
                }).First()
            };
        }

        public HospitalsViewModel GetHospitalEdit(int id)
        {

            return new HospitalsViewModel
            {
                Edit = db.Hospitals.Select(e => new HospitalEditViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Address = e.Address,
                    Sor = e.Sor,
                    Describtion = e.SorDescribtion,
                    Active = e.Active
                }).First()
            };
        }




        public bool CreateHospital(HospitalCreateViewModel hospital)
        {
            string describtion;
            if (hospital.Sor)
            {
                describtion = hospital.Describtion;
            } else {
                describtion = null;
            }
            Hospital h = new Hospital
            {
                Name = hospital.Name,
                Address = hospital.Address,
                Sor = hospital.Sor,
                SorDescribtion = describtion,
                Active = hospital.Active,
            };


            db.Hospitals.Add(h);
            db.SaveChanges();

            return true;
        }


        public bool EditHospital(HospitalEditViewModel hospital)
        {
            string describtion;
            if (hospital.Sor)
            {
                describtion = hospital.Describtion;
            }
            else
            {
                describtion = null;
            }

            Hospital h = db.Hospitals.Find(hospital.Id);
            h.Id = hospital.Id;
            h.Name = hospital.Name;
            h.Address = hospital.Address;
            h.Sor = hospital.Sor;
            h.SorDescribtion = describtion;
            h.Active = hospital.Active;
            
            db.SaveChanges();

            return true;
        }

        public bool DeleteHospital(int id) {

            Hospital hospital = db.Hospitals.Find(id);
            db.Hospitals.Remove(hospital);
            db.SaveChanges();
            return true;
        }

    }
}
