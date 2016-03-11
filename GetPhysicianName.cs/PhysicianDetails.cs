using DataAccess;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPhysicianName.cs
{
    public class PhysicianDetails : IPhysicianDetails
    {
        PhysicianData physicianData;
        public PhysicianDetails()
        {
            physicianData = new PhysicianData();
        }
        public IEnumerable<Physician> GetAllPhysicianDetails()
        {
            var physicianNames = physicianData.GetAllPhysicianName();
            return physicianNames.Select(x => new Physician { FirstName = x }).ToList();            
        }
    }
}
