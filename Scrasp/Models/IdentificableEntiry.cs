using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrasp.Models
{
    public abstract class IdentifiableEntity
    {
        private int lastId = 0;
        private int id;

        protected IdentifiableEntity()
        {
            this.lastId++;
            this.id = LastId;
        }

        public int LastId { get => lastId; set => lastId = value; }
        public int Id { get => id; set => id = value; }
    }
}