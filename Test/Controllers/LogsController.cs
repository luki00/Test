using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Repos;
using Domain.ViewModels;

namespace Test.Controllers
{
    public class LogsController : Controller
    {
        ILogsRepo logsRepo;

        public LogsController()
        {
            logsRepo = new LogsRepo();
        }
        // GET: Logs
        public ActionResult Index()
        {
            return View(logsRepo.GetLogsList());
        }
    }
}