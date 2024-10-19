using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class DisposalContent: Content
    {
        public Item Item { get; set; }
        public List<Bin> Bins { get; set; }
        public DisposalContent(
            string title,
            string body,
            User author, 
            DateTime timeCreated,
            DateTime timeLastModofied,
            int countOfClick,
            Item item, 
            List<Bin> bins) : base (
            title,
            body,
            author,
            timeCreated,
            timeLastModofied
            )
        {
            Item = item;
            Bins = bins;
            countOfClick = 0;
        }
    }
}
