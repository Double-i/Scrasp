using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Story : IdentifiableEntity
    {
        private String description;
        private String refName;
        private String actor;
        private int type;
        private int state;
        private int points;
        private List<Task> tasks;

        public Story(string description, string refName, string actor, int type, int state, int points, List<Task> tasks)
        {
            this.description    = description;
            this.refName        = refName;
            this.actor          = actor;
            this.type           = type;
            this.state          =  state;
            this.points         = points;
            this.tasks          = tasks;
        }

        public string Description { get => description; set => description = value; }
        public string RefName { get => refName; set => refName = value; }
        public string Actor { get => actor; set => actor = value; }
        public int Type { get => type; set => type = value; }
        public int State { get => state; set => state = value; }
        public int Points { get => points; set => points = value; }
        public List<Task> Tasks { get => tasks; set => tasks = value; }
    }
}