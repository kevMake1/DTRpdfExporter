using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTR.Model
{
    public class Companies
    {
        public List<Shipper> shippers1 = new List<Shipper>()
        {
            new Shipper(1, "test"),
            new Shipper(2, "MC Transport\n100 John Hay ave\nKearny, NJ\nzipCode")
        };
        public List<Cosignee> cosignees1 = new List<Cosignee>()
        {
            new Cosignee(1, "test")
        };
    }
}
