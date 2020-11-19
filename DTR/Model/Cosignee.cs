using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTR.Model
{
    public class Cosignee
    {
        //[PrimaryKey, AutoIncrement] //sqlite
        public int Id { get; set; }
        public string CosigneeInfo { get; set; }

        public override string ToString()
        {
            return $"{CosigneeInfo}";
        }

        public Cosignee(int id, string str)
        {
            Id = id;
            CosigneeInfo = str;
        }
    }
}
