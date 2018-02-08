using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Sprint : IdentifiableEntity
    {
        private int number;
        private String description;
        private DateTime startDate;
        private DateTime endDate;
        private List<Story> stories; 

        public Sprint(int number, string description, DateTime startDate, DateTime endDate)
        {
            this.number         = number;
            this.description    = description;
            this.startDate      = startDate;
            this.endDate        = endDate;
        }
        public void AddStory (Story newStory)
        {
            this.stories.Add(newStory);
        }
        public void AddStories (List<Story> newStories)
        {
            this.stories.AddRange(newStories);
        }

      
    }

}