using shelldemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shelldemoAPI.Iservices
{
    public interface ITestTableservicee
    {
        IEnumerable<TestTable> GetTestTable();
       TestTable GetTestTableById(int id);
        TestTable AddTestTable(TestTable testtable);
        TestTable UpdateTestTable(TestTable testtable);
        TestTable DeleteTestTable(int id);
    }
}
