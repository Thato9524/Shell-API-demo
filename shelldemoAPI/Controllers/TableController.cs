using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shelldemoAPI.Iservices;
using shelldemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shelldemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITestTableservicee tableservicee;
        public TableController(ITestTableservicee testtable)
        {
            tableservicee = testtable;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/TestTable/GetTestTable")]
        public IEnumerable<TestTable> GetTestTable()
        {
            return tableservicee.GetTestTable();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/TestTable/AddTestTable")]
        public TestTable AddTestTable(TestTable testtable)
        {
            return tableservicee.AddTestTable(testtable);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/TestTable/EditTestTable")]
        public TestTable EditTestTable(TestTable testtable)
        {
            return tableservicee.UpdateTestTable(testtable);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/TestTable/DeleteTestTable")]
        public TestTable DeleteTestTable(int id)
        {
            return tableservicee.DeleteTestTable(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/TestTable/GetTestTableId")]
        public TestTable GetTestTable(int id)
        {
            return tableservicee.GetTestTableById(id);
        }
    }
}

