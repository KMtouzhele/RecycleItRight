using RecycleItRight.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Content
    {
        public string ContentId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Video { get; set; }
        public Category Category { get; set; }
        public User Author { get; set; }
        public DateTime LastModified { get; set; }
        public Content(string contentId, string title, string body, string video, Category category, User author, DateTime date)
        {
            ContentId = contentId;
            Title = title;
            Body = body;
            Video = video;
            Category = category;
            Author = author;
            LastModified = date;
        }
        public void Edit(string title, string body, string video)
        {
            Title = title;
            Body = body;
            Video = video;
            LastModified = DateTime.Now;
            Console.WriteLine("Content edited successfully.");
        }
        public void Create(string title, string body, string video, Category category, User author) {
            Title = title;
            Body = body;
            Video = video;
            Category = category;
            Author = author;
            LastModified = DateTime.Now;
            ContentAdapter adapter = new ContentAdapter();
            adapter.CreateContentToDB(this);
            Console.WriteLine("Content created successfully.");
        }
    }

    public enum Category
    {
        Disposal,
        Knowledge,
        Article,
        Tip,
        Video,
        Quiz
    }
}
