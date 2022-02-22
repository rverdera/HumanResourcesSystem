﻿using System;
using System.Collections.Generic;

namespace HRSWebAPI.Models
{
    public partial class PersonalInformation
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ExtName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = null!;
        public bool Sex { get; set; }
        public int CivilStatusId { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public int BloodTypeId { get; set; }
        public string? Gsis { get; set; }
        public string? Pagibig { get; set; }
        public string? Philhealth { get; set; }
        public string? Sss { get; set; }
        public string? Tin { get; set; }
        public string? AgencyEmployeeNo { get; set; }
        public bool IsFilipinoOrDualCitizen { get; set; }
        public bool? IsDualCitizenByBirthOrByNaturalization { get; set; }
        public int? CountryId { get; set; }
        public string? CurrentHouseBlkLotNo { get; set; }
        public string? CurrentStreet { get; set; }
        public string? CurrentSubdivisionVillage { get; set; }
        public int? CurrentCmid { get; set; }
        public string? PermanentHouseBlkLotNo { get; set; }
        public string? PermanentStreet { get; set; }
        public string? PermanentSubdivisionVillage { get; set; }
        public int? PermanentCmid { get; set; }
        public string? TelephoneNo { get; set; }
        public string? MobilePhone { get; set; }
        public string? PersonalEmailAddress { get; set; }
        public bool IsDel { get; set; }
        public string UserStamp { get; set; } = null!;
        public DateTime DateStamp { get; set; }

        public virtual BloodType BloodType { get; set; } = null!;
        public virtual CivilStatus CivilStatus { get; set; } = null!;
        public virtual Country? Country { get; set; }
        public virtual PhilippineDirectory? CurrentCm { get; set; }
        public virtual PhilippineDirectory? PermanentCm { get; set; }
    }
}