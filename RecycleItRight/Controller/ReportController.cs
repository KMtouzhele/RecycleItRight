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
        public string data;
        public ReportController()
        {
            this.itemAdapter = new ItemAdapter();
            this.contentAdapter = new ContentAdapter();
            this.data = "";
        }
        public string VisualizeData() {
            string scanData = itemAdapter.FetchScanData();
            string engagementData = contentAdapter.fetchEngagementData();
            string interactionData = contentAdapter.fetchInteractionData();
            this.data = scanData + engagementData + interactionData;
            return this.data;
        }

        public void PrepareReport() {
            string report = this.data;
            Console.WriteLine(report + " is exported.");
        }
    }
}
