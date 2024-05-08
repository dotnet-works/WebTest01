using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class RootData
    {
        public Data1 data1 { get; set; }
        public Data2 data2 { get; set; }
    }

    public class Data1
    {
        public string p1 { get; set; }
        public string p2 { get; set; }
    }

    public class Data2
    {
        public string A1 { get; set; }
        public string B1 { get; set; }
        public string C1 { get; set; }
    }

}
