using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repos
{
    public interface IHospitalsRepo
    {
        HospitalsViewModel GetHospitalsList();
        HospitalsViewModel GetHospitalDetails(int id);
        bool CreateHospital(HospitalCreateViewModel hospital);
        bool EditHospital(HospitalEditViewModel hospital);
        HospitalsViewModel GetHospitalEdit(int id);
        bool DeleteHospital(int id);
    }
}
