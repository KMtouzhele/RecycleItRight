using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecycleItRight.Entity;

namespace RecycleItRight.Adapter
{
    public class BinLocationAdapter
    {
        public List<Bin> bins = new List<Bin>();
        public List<Bin> FetchBinLocation(DisposalMethod method) {
            DBconnection();
            List<Bin> result = new List<Bin>();
            foreach (Bin bin in bins)
            {
                if (bin.DisposalMethod == method)
                {
                    result.Add(bin);
                }
            }
            return result;
        }
        private void DBconnection()
        {
            Console.WriteLine("Connecting to the database...");
            if (bins.Count == 0)
            {
                bins.Add(new Bin(DisposalMethod.Landfill, "1st Floor, Builidng A"));
                bins.Add(new Bin(DisposalMethod.Recycle, "2nd Floor, Builidng A"));
                bins.Add(new Bin(DisposalMethod.Compost, "3rd Floor, Builidng B"));
            }
            Console.WriteLine("Connected to database -> bins Table!");
        }

    }
}
