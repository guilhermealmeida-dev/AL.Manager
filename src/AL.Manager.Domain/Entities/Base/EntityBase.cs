using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AL.Manager.Domain.Entities.Base
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}