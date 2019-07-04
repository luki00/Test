using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Domain.ViewModels
{
    public class HospitalsViewModel
    {
        public List<HospitalsGetViewModel> List { get; set;}
        public HospitalsGetViewModel Details { get; set; }
        public HospitalsSetViewModel Edit { get; set; }
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

    public class HospitalsSetViewModel
    {
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



}
