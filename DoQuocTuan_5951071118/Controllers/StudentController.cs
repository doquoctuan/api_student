using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Models;
using TestAPI;
namespace TestAPI.Controllers
{
    public class StudentController : ApiController
    {
        List<String> listInfo = new List<String>();
        
        // GET: api/Student
        public IEnumerable<String> Get()
        {
            listInfo.Add("MSSV: 5951071118");
            listInfo.Add("Do Quoc Tuan");
            listInfo.Add("Address: Quan 9, HCM");
            listInfo.Add("Mobile: 0367717714");
            return listInfo;
        }

        // GET: api/Student/5
        public String Get(int id)
        {
            listInfo.Add("MSSV: 5951071118");
            listInfo.Add("Do Quoc Tuan");
            listInfo.Add("Address: Quan 9, HCM");
            listInfo.Add("Mobile: 0367717714");
            return listInfo[id].Trim();
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
