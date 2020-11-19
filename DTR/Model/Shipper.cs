using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTR.Model
{
    public class Shipper
    {
        //[PrimaryKey, AutoIncrement] //sqlite
        public int Id { get; set; }
        public string ShipperInfo { get; set; }

        public override string ToString()
        {
            return $"{ShipperInfo}";
        }

        public Shipper(int id, string str)
        {
            Id = id;
            ShipperInfo = str;
        }
    }
}
