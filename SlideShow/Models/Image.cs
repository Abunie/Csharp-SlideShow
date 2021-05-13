using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideShow.Models
{
    public class Image
    {   
        public String Count { get; set; }
        public String Src { get; set; }
        public String Caption { get; set; }

        public Image(String count, String src, String caption)
        {
            this.Count = count;
            this.Src = src;
            this.Caption = caption;
        }
    }
}
