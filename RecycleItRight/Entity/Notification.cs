using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Notification
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public Notification(string title, string subtitle)
        {
            Title = title;
            Subtitle = subtitle;
        }
    }
}
