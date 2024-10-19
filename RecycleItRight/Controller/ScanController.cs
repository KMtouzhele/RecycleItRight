using RecycleItRight.Adapter;
using RecycleItRight.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Controller
{
    public class ScanController
    {
        public ItemAdapter itemAdapter;
        public ScanController()
        {
            this.itemAdapter = new ItemAdapter();
        }
        public Item? Detect(string image) {
            if (itemAdapter.FetchItem(image) == null) {
                return null;
            }
            else
            {
                Item item = itemAdapter.FetchItem(image)!;
                itemAdapter.IncrementSearch(item);
                return item;
            }
        }
        public void HandleDetectionFailure() {
            Console.WriteLine("Navigating to Mannual Search...");
        }
    }
}
