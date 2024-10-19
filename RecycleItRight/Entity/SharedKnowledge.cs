using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class SharedKnowledge: Content
    {
        public List<string> Comments { get; set; }
        public SharedKnowledge(
            string title,
            string body,
            User author,
            DateTime timeCreated,
            DateTime timeLastModified,
            int countOfClick,
            List<string> comments
            ) : base(
                title, 
                body, 
                author, 
                timeCreated, 
                timeLastModified
                )
        {
            countOfClick = 0;
            Comments = comments;
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }

    
}
