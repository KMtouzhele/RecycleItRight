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
        List<Content> contents = new List<Content>();
        public List<EducationalContent> fetchEducationalByCategory(Category category) {
            DBConnect();
            List<EducationalContent> result = new List<EducationalContent>();
            foreach (Content content in contents)
            {
                if (content is EducationalContent)
                {
                    EducationalContent educationalContent = (EducationalContent)content;
                    if (educationalContent.Category == category)
                    {
                        result.Add(educationalContent);
                    }
                }
            }
            return result;
        }
        public void SaveNewContent(Content content) {
            DBConnect();
            contents.Add(content);
            Console.WriteLine("New content saved to the database!");
        }
        public void UpdateContent(Content content)
        {
            DBConnect();
            foreach (Content c in contents)
            {
                if (c.ContentId == content.ContentId)
                {
                    c.Title = content.Title;
                    c.Body = content.Body;
                    c.TimeLastModified = DateTime.Now;
                    c.Author = content.Author;
                    Console.WriteLine("Content updated in the database!");
                    return;
                }
            }
        }
        public void DeleteContent(Guid contentId)
        {
            DBConnect();
            foreach (Content content in contents)
            {
                if (content.ContentId == contentId)
                {
                    contents.Remove(content);
                    Console.WriteLine("Content deleted from the database!");
                    return;
                }
            }
        }
        public DisposalContent? FetchDisposalContent(Item item) {
            DBConnect();
            foreach (Content content in contents)
            {
                if (content is DisposalContent)
                {
                    DisposalContent disposalContent = (DisposalContent)content;
                    if (disposalContent.Item == item)
                    {
                        return disposalContent;
                    }
                }
            }
            return null;
        }

        public string fetchEngagementData() {
            return "This is engagement data";
        }
        public string fetchInteractionData() {
            return "This is interaction data";
        }
        private void DBConnect() {
            Console.WriteLine("Connecting to the database...");
            if (contents.Count == 0) {
                Content content1 = new Content(
                    "Recycling 101",
                    "DemoBody",
                    new User("John Doe", "Jd@gmail.com", "password", "John", "Doe"),
                    DateTime.Now,
                    DateTime.Now);
                Content content2 = new Content(
                    "Recycling 102",
                    "DemoBody",
                    new User("Jane Doe", "jq@gmail.com", "password", "Jane", "Doe"),
                    DateTime.Now,
                    DateTime.Now);
                contents.Add(content1);
                contents.Add(content2);
            }
            Console.WriteLine("Connected to database -> contents Table!");
        }
    }
}
