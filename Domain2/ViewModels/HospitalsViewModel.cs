using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;



namespace Domain.ViewModels
{
    public class HospitalsViewModel
    {
        public List<HospitalsGetViewModel> List { get; set;}
        public HospitalsGetViewModel Details { get; set; }
        public HospitalEditViewModel Edit { get; set; }
        public HospitalCreateViewModel Create { get; set; }
    }

    public class HospitalsGetViewModel {
        public int Id { get; set; }
        [Display(Name = "Nazwa szpitala")]
        public string Name { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        public bool Sor { get; set; }
        [Display(Name = "Opis SOR")]
        public string Describtion { get; set; }
        public bool Active { get; set; }
    }

    public class HospitalEditViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa szpitala")]
        public string Name { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Pokaż opis SOR")]
        public bool Sor { get; set; }
        [Display(Name = "Opis SOR")]
        public string Describtion { get; set; }
        public bool Active { get; set; }
    }

    public class HospitalCreateViewModel
    {
        [Display(Name = "Nazwa szpitala")]
        public string Name { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        public bool Sor { get; set; }
        [Display(Name = "Opis SOR")]
        public string Describtion { get; set; }
        public bool Active { get; set; }
    }



}
