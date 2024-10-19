using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DisposalMethod DisposalMethod { get; set; }
        public int SearchTimes { get; set; }

        public Item(string name, string image, DisposalMethod disposalMethod)
        {
            Name = name;
            Image = image;
            DisposalMethod = disposalMethod;
            SearchTimes = 0;
        }
    }
    public enum DisposalMethod
    {
        Recycle,
        Landfill,
        Compost,
        Reuse,
        Default
    }
}
