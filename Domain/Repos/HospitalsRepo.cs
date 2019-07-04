using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

using Test.Models;

namespace Domain.Repos
{
    public class HospitalsRepo : IHospitalsRepo
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public HospitalsViewModel GetHospitalsList()
        {

            return new HospitalsViewModel
            {
                List = db.Hospitals.Select(e => new HospitalsGetViewModel
                {
                Id = e.Id, 
		        Name = e.Name,
		        Address = e.Address,
		        Describtion = e.Descibtion,
		        Active = e.Active
                }).ToList()
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
                    Describtion = e.Descibtion,
                    Active = e.Active
                }).First()
            };
        }


    }
}
