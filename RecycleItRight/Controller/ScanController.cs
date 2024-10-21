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
        public ContentAdapter contentAdapter;
        public BinLocationAdapter binAdapter;
        public ScanController()
        {
            this.itemAdapter = new ItemAdapter();
            this.contentAdapter = new ContentAdapter();
            this.binAdapter = new BinLocationAdapter();
        }
        public Item? Detect(string image) {
            if (itemAdapter.FetchItemByImg(image) == null) {
                return null;
            }
            else
            {
                Item item = itemAdapter.FetchItemByImg(image)!;
                itemAdapter.IncrementSearch(item);
                return item;
            }
        }

        public Item? Search(string keyword) {
            Item? item = itemAdapter.FetchItemByName(keyword);
            if (item == null)
            {
                Console.WriteLine("Item not found in database...");
                return null;
            }
            else
            {
                return item;
            }
        }

        public DisposalContent? DisplayDisposalContentByItem(Item item) {
            DisposalContent? content = contentAdapter.FetchDisposalContent(item);
            if (content == null)
            {
                Console.WriteLine("No disposal content found for this item...");
                return null;
            }
            else
            {
                return content;
            }
        }
        public List<Bin> ListBinLocation(DisposalMethod method)
        {
            List<Bin> bins = binAdapter.FetchBinLocation(method);
            return bins;
        }
        public void HandleDetectionFailure() {
            Console.WriteLine("Navigating to Mannual Search...");
        }
    }
}
