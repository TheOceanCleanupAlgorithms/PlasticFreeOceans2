using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPlasticFreeOceans2
{
    public class PhotoResponse
    {
        public string predictions { get; set; }
        public string detection_boxes { get; set;}
        public string detection_classes { get; set;}
        public string detection_scores { get; set; }
    }
}
