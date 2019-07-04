using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Sor { get; set; }
        public string SorDescribtion { get; set; }
        public bool Active { get; set; }
    }
}