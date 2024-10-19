using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Bin
    {
        public Guid BinId { get; set; }
        public DisposalMethod DisposalMethod { get; set; }
        public string Location { get; set; }

        public Bin(DisposalMethod method, string location) {
            DisposalMethod = method;
            Location = location;
        }
    }
}
