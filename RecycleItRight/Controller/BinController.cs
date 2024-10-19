using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecycleItRight.Adapter;
using RecycleItRight.Entity;

namespace RecycleItRight.Controller
{
    public class BinController
    {
        public BinLocationAdapter binAdapter;
        public BinController()
        {
            this.binAdapter = new BinLocationAdapter();
        }
        public List<Bin> ListBinLocation(DisposalMethod method) {
            List<Bin> bins = binAdapter.FetchBinLocation(method);
            return bins;
        }
    }
}
