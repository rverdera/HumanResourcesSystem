using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class Relationship
    {
        public int RelationshipId { get; set; }
        public string? RelationshipDesc { get; set; }
        public bool? IsDel { get; set; }
    }
}
