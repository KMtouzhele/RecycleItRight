using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecycleItRight.Adapter;
using RecycleItRight.Entity;

namespace RecycleItRight.Controller
{
    public class ItemController
    {
        public ItemAdapter itemAdapter;
        public ItemController()
        {
            this.itemAdapter = new ItemAdapter();
        }
        public void Create(Item item) {
            itemAdapter.SaveItem(item);
        }

        public void Edit(Item item)
        {
            itemAdapter.UpdateItem(item);
        }

        public void Delete(Item item)
        {
            itemAdapter.DeleteItem(item.ItemId);
        }
    }
}
