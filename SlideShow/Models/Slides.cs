using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
namespace SlideShow.Models
{
    public class Slides
    {

       
        
        private List<Image> Images { get; set; }

        public Slides(IConfigurationRoot configuration)
        {
            this.Images = new List<Image>();
            parseJson(configuration);
        }

        public List<Image> getImages()
        {
            return Images;
        }

        private void parseJson(IConfigurationRoot configuration)
        {
            var sections = configuration.GetSection("images");
            foreach (IConfigurationSection section in sections.GetChildren())
            {
                if (section == null)
                {
                    continue;
                }
                else
                {
                    var count = section.GetValue<String>("count");
                    var src = section.GetValue<String>("src");
                    var caption = section.GetValue<String>("caption");
                    var img = new Image(count, src, caption);
                    Images.Add(img);
                }
            }
        }
    }
}
