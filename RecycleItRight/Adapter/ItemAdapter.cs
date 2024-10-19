using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecycleItRight.Entity;

namespace RecycleItRight.Adapter
{
    public class ItemAdapter
    {
        public List<Item> items = new List<Item>();

        public void SaveItem(Item item)
        {
            DBConnection();
            items.Add(item);
            Console.WriteLine("Item " + item.Name + " saved to database...");
        }
        public Item? FetchItem(string image) {
            DBConnection();
            int randomNumber = new Random().Next(0, items.Count);
            if (randomNumber == items.Count) {
                Console.WriteLine("Item not found in database...");
                return null;
            }
            else
            {
                Item foundItem = items[randomNumber];
                Console.WriteLine("Item " + foundItem.Name + "found in database...");
                return foundItem;
            }
        }

        public void DeleteItem(Guid ItemId) {
            DBConnection();
            foreach (Item item in items)
            {
                if (item.ItemId == ItemId)
                {
                    items.Remove(item);
                    Console.WriteLine("Item " + item.Name + " removed from database...");
                    return;
                }
            }
            Console.WriteLine("Item not found in database...");
        }
        public void UpdateItem(Item item)
        {
            DBConnection();
            foreach (Item i in items)
            {
                if (i.ItemId == item.ItemId)
                {
                    i.Name = item.Name;
                    i.Image = item.Image;
                    i.DisposalMethod = item.DisposalMethod;
                    Console.WriteLine("Item " + item.Name + " updated in database...");
                    return;
                }
            }
            Console.WriteLine("Item not found in database...");
        }
        public void IncrementSearch(Item item) {
            foreach (Item i in items) {
                if (i.ItemId == item.ItemId)
                {
                    i.SearchTimes++;
                }
            }
        }

        public string FetchScanData() {
            //pretent thismethod will return a Json or XML data
            return "Scan Data";
        }
        private void DBConnection()
        {
            Console.WriteLine("Connecting to the database...");
            Console.WriteLine("Connected to database -> items Table!");
            if (items.Count == 0)
            {
                items.Add(new Item("Plastic Bottle", "plastic_bottle.jpg", DisposalMethod.Recycle));
                items.Add(new Item("Coke Can", "coke_can.jpg", DisposalMethod.Recycle));
                items.Add(new Item("Coffee cup", "paper.jpg", DisposalMethod.Compost));
            }
        }
    }
}
