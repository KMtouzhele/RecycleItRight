using RecycleItRight.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Adapter
{
    public class ContentAdapter
    {
        public void CreateContentToDB(Content content)
        {
            Console.WriteLine("--------------------Creating Content---------------------");
            Console.WriteLine("Creating content named " + content.Title + "...");
            Console.WriteLine("Content created successfully");
            Console.WriteLine("--------------------Content Created---------------------\n");
        }
    }
}
