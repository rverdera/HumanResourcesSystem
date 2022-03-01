namespace HRSWebAPI.Models
{
    public partial class OtherInformationQuestion
    {
        public int RecordId { get; set; }
        public int PersonId { get; set; }
        public bool IsWithinThirdDegree { get; set; }
        public bool IsWithinFourthDegree { get; set; }
        public string FourthDegreeDetails { get; set; } = null!;
        public bool IsGuiltyAdministrativeOffense { get; set; }
        public string GuiltyAdministrativeOffenseDetails { get; set; } = null!;
        public bool IsCriminallyCharged { get; set; }
        public DateTime CriminallyChargedDateFiled { get; set; }
        public string CriminallyChargedStatusCase { get; set; } = null!;
        public bool IsConvicted { get; set; }
        public string ConvictedDetails { get; set; } = null!;
        public bool IsSeparatedInService { get; set; }
        public string SeparatedInServiceDetails { get; set; } = null!;
        public bool IsCandidate { get; set; }
        public string CandidateDetails { get; set; } = null!;
        public bool IsResignedFromGovernment { get; set; }
        public string ResignedFromGovernmentDetails { get; set; } = null!;
        public bool IsImmigrant { get; set; }
        public string ImmigrantDetails { get; set; } = null!;
        public bool IsIndigenous { get; set; }
        public int EthnicGroupId { get; set; }
        public bool IsPwd { get; set; }
        public string Pwdno { get; set; } = null!;
        public bool IsSoloParent { get; set; }
        public string SoloParentId { get; set; } = null!;
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual PersonalInformation Person { get; set; } = null!;
    }
}
