using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModels
{
    public class LogsViewModel
    {
        public List<LogsListViewModel> List { get; set; }
    }

    public class LogsListViewModel {
        [Display(Name = "Nowa nazwa szpitala")]
        public string NewName { get; set; }
        [Display(Name = "Stara nazwa szpitala")]
        public string OldName { get; set; }
        [Display(Name = "Data zmiany")]
        public DateTime Time { get; set; }
    }

}
