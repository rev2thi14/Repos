using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteData
{
    class TutorialModel
    {
        public int TutorialId { get; set; }
        public string TutorialName { get; set; }
        public string TutorialDesc { get; set; }
        public int Published { get; set; }
        public int TutorialFees { get; set; }
    }
}
