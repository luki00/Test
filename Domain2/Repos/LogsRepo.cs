
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Test.Models;

namespace Domain.Repos
{
    public class LogsRepo : ILogsRepo
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public LogsViewModel GetLogsList() {

            return new LogsViewModel
            {

                List = db.Logs.Select(e => new LogsListViewModel
                {
                    NewName = e.NewName,
                    OldName = e.OldName,
                    Time = e.Time

                }).ToList()
                
            };
            
            }


    }

}
