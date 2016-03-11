using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PhysicianData : DBFetcher
    {


        public IEnumerable<string> GetAllPhysicianName()
        {
            var physicianDetails = this.Select("Select * from Physician");
            return physicianDetails.Rows.Cast<DataRow>().Select(x => x["FirstName"].ToString());
           
        }
    }
}
