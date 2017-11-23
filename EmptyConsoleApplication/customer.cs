using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class customer
    {
        public CustomerBase BaseInfo { get; set; }
        public List<int> Accounts { get; set; }
        public string Profession { get; set; }
        public CustomerAdress AdressInfo { get; set; }
    }
}
