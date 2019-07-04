using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repos
{
    public interface ILogsRepo
    {
        LogsViewModel GetLogsList();
    }
}
