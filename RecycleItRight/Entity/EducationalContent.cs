using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class EducationalContent: Content
    {
        public Category Category { get; set; }
        public EducationalContent(
            string title,
            string body,
            User author,
            DateTime timeCreated,
            DateTime timeLastModified,
            Category category
            ) : base(
                title,
                body,
                author,
                timeCreated,
                timeLastModified
                )
        {
            Category = category;
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
