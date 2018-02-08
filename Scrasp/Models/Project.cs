using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public class Project : IdentifiableEntity
    {
        private String title;
        private String description;
        private String refRepo;
        private List<User> team;
        private List<Sprint> sprints;

        public Project(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public string RefRepo { get => refRepo; set => refRepo = value; }
        
        public void AddUser(User newUser)
        {
            this.team.Add(newUser);
        }
        public void AddUsers(List<User> newUser)
        {
            this.team.AddRange(newUser);
        }
    }
}