using System;

namespace Scrasp.Models
{
    class Task
    {
        private string description;
        private int state;
        private User owner;
        private DateTime plannedStart;
        private DateTime plannedDuration;

        public Task(string description, int state, User owner, DateTime plannedStart, DateTime plannedDuration)
        {
            this.description = description;
            this.state = state;
            this.owner = owner;
            this.plannedStart = plannedStart;
            this.plannedDuration = plannedDuration;
        }

        public string Description { get => description; set => description = value; }
        public int State { get => state; set => state = value; }
        public User Owner { get => owner; set => owner = value; }
        public DateTime PlannedStart { get => plannedStart; set => plannedStart = value; }
        public DateTime PlannedDuration { get => plannedDuration; set => plannedDuration = value; }
    }
}