using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class Relationship
    {
        public Relationship()
        {
            FamilyBackgrounds = new HashSet<FamilyBackground>();
        }

        public int RelationshipId { get; set; }
        public string RelationshipDesc { get; set; } = null!;
        public bool IsDel { get; set; }

        public virtual ICollection<FamilyBackground> FamilyBackgrounds { get; set; }
    }
}
