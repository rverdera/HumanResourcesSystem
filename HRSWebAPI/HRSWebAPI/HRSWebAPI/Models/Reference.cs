using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class Reference
    {
        public int RecordId { get; set; }
        public int PersonId { get; set; }
        public string NameOfReference { get; set; } = null!;
        public string ReferenceAddress { get; set; } = null!;
        public string TelNo { get; set; } = null!;
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual PersonalInformation Person { get; set; } = null!;
    }
}
