using System;
using System.Collections.Generic;

#nullable disable

namespace shelldemoAPI.Models
{
    public partial class TestTable
    {
        // sql db table variables will appear here 
        // made a demo table to test api shell 
        //you(sasfin) will remove and populate with your table variables 
        public int Id { get; set; }
        public string TestName { get; set; }
        public string TestDetails { get; set; }
        public decimal? TestSalary { get; set; }
    }
}
