using Microsoft.EntityFrameworkCore;
using shelldemoAPI.Iservices;
using shelldemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shelldemoAPI.Controllers.Services
{
    public class TestTableservices : ITestTableservicee
    {
        TestApiDbContext testApiDbContext;
        public TestTableservices(TestApiDbContext _db)
        {

            testApiDbContext = _db;
        }


        public IEnumerable<TestTable> GetTestTable()
        {
            var testtable = testApiDbContext.TestTables.ToList();
            return testtable;
        }
        public TestTable AddTestTable(TestTable testtable)
        {
            if (testtable != null)
            {
                testApiDbContext.TestTables.Add(testtable);
                testApiDbContext.SaveChanges();
                return testtable;
            }
            return null;
        }
        public TestTable UpdateTestTable(TestTable testtable)
        {
            testApiDbContext.Entry(testtable).State = EntityState.Modified;
            testApiDbContext.SaveChanges();
            return testtable;
        }

        public TestTable DeleteTestTable(int id)
        {
            var testtable = testApiDbContext.TestTables.FirstOrDefault(x => x.Id == id);
            testApiDbContext.Entry(testtable).State = EntityState.Deleted;
            testApiDbContext.SaveChanges();
            return testtable;
        }

        public TestTable GetTestTableById(int id)
        {
            var testtable = testApiDbContext.TestTables.FirstOrDefault(x => x.Id == id);
            return testtable;
        }
    }


}
