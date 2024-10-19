using RecycleItRight.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Content
    {
        public Guid ContentId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeLastModified { get; set; }
        public Notification? Notification { get; set; }
        public int CountOfClick { get; set; }
        public Content( string title, string body, User author, DateTime timeCreated, DateTime timeLastModofied)
        {
            Title = title;
            Body = body;
            Author = author;
            TimeCreated = timeCreated;
            TimeLastModified = timeLastModofied;
            CountOfClick = 0;

        }
        public void Notify()
        {
            if (Notification == null)
            {
                Console.WriteLine("No notification set for this content.");
                return;
            }

            string title = string.IsNullOrEmpty(Notification.Title) ? "No Title" : Notification.Title;
            string subtitle = string.IsNullOrEmpty(Notification.Subtitle) ? "No Subtitle" : Notification.Subtitle;

            Console.WriteLine($"Notification: {title} - {subtitle}");
        }

    }
}
