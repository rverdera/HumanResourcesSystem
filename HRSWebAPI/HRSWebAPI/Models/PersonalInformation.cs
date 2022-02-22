using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class PersonalInformation
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ExtName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = null!;
        public bool Sex { get; set; }
        public int CivilStatusID { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public int BloodTypeID { get; set; }
        public string? GSIS { get; set; }
        public string? PAGIBIG { get; set; }
        public string? PHILHEALTH { get; set; }
        public string? SSS { get; set; }
        public string? TIN { get; set; }
        public string? AgencyEmployeeNo { get; set; }
        public bool IsFilipinoOrDualCitizen { get; set; }
        public bool? IsDualCitizenByBirthOrByNaturalization { get; set; }
        public int? CountryID { get; set; }
        public string? CurrentHouseBlkLotNo { get; set; }
        public string? CurrentStreet { get; set; }
        public string? CurrentSubdivisionVillage { get; set; }
        public int? CurrentCMID { get; set; }
        public string? PermanentHouseBlkLotNo { get; set; }
        public string? PermanentStreet { get; set; }
        public string? PermanentSubdivisionVillage { get; set; }
        public int? PermanentCMID { get; set; }
        public string? TelephoneNo { get; set; }
        public string? MobilePhone { get; set; }
        public string? PersonalEmailAddress { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual BloodType BloodType { get; set; } = null!;
        public virtual CivilStatus CivilStatus { get; set; } = null!;
        public virtual Country? Country { get; set; }
        public virtual PhilippineDirectory? CurrentCM { get; set; }
        public virtual PhilippineDirectory? PermanentCM { get; set; }
    }
}
