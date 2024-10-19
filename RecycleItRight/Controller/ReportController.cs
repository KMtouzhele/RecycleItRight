using RecycleItRight.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Controller
{
    public class ReportController
    {
        public ItemAdapter itemAdapter;
        public ContentAdapter contentAdapter;
        public ReportController()
        {
            this.itemAdapter = new ItemAdapter();
            this.contentAdapter = new ContentAdapter();
        }
        public string VisualizeData() {
            string scanData = itemAdapter.FetchScanData();
            string engagementData = contentAdapter.fetchEngagementData();
            string interactionData = contentAdapter.fetchInteractionData();
            return scanData + engagementData + interactionData;

        }
    }
}
