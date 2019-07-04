using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string NewName { get; set; }
        public string OldName { get; set; }
        public DateTime Time { get; set; }
    }
}