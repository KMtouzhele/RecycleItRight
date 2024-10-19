using RecycleItRight.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecycleItRight.Entity;

namespace RecycleItRight.Controller
{
    public class ContentController
    {
        public ContentAdapter contentAdapter;
        public ContentController()
        {
            this.contentAdapter = new ContentAdapter();
        }
        public void Create(Content content) {
            contentAdapter.SaveNewContent(content);
        }
        public void Edit(Content content) {
            contentAdapter.UpdateContent(content);
        }
        public void Delete(Guid contentId)
        {
            contentAdapter.DeleteContent(contentId);
        }
    }
}
