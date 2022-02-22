using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class FamilyBackground
    {
        public int RecordId { get; set; }
        public int? PersonId { get; set; }
        public int? RelationshipId { get; set; }
        public string? Occupation { get; set; }
        public string? BusinessName { get; set; }
        public string? BusinessAddress { get; set; }
        public bool IsDependent { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual PersonalInformation? Person { get; set; }
        public virtual Relationship? Relationship { get; set; }
    }
}
