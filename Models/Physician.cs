using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Physician
    {
        public string FirstName { get; set; }
    }


    public class PhysicianList
    {
        public IEnumerable<Physician> Details { get; set; }
    }
}