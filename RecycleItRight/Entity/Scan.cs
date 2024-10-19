using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Entity
{
    public class Scan
    {
        public string ImageCaptured { get; set; }
        public DateTime TimeScanned { get; set; }

        public Scan(string imageCaptured, DateTime timeScanned) {
            ImageCaptured = imageCaptured;
            TimeScanned = timeScanned;
        }
    }
}
