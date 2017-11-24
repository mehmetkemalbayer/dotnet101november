using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class Customer
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public long  CitizenId { get; set; }
        public int CustomerId{ get; set; }
        public List<int> Accounts { get; set; }
        public string HomeAdress { get; set; }
        public string WorkAdress { get; set; }
        
    }
}
