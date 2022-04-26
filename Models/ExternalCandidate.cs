using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("ExternalCandidate")]
    public partial class ExternalCandidate
    {
        public ExternalCandidate()
        {
            CandidateSkills = new HashSet<CandidateSkill>();
            EmployeeReferrals = new HashSet<EmployeeReferral>();
        }

        [Key]
        [Column("cCandidateCode")]
        [StringLength(6)]
        public string CCandidateCode { get; set; }
        [Column("vFirstName")]
        [StringLength(20)]
        public string VFirstName { get; set; }
        [Column("vLastName")]
        [StringLength(20)]
        public string VLastName { get; set; }
        [Column("vAddress")]
        [StringLength(35)]
        public string VAddress { get; set; }
        [Column("cCity")]
        [StringLength(20)]
        public string CCity { get; set; }
        [Column("cState")]
        [StringLength(15)]
        public string CState { get; set; }
        [Column("cZip")]
        [StringLength(10)]
        public string CZip { get; set; }
        [Column("cCountryCode")]
        [StringLength(3)]
        public string CCountryCode { get; set; }
        [Column("cPhone")]
        [StringLength(15)]
        public string CPhone { get; set; }
        [Column("cPositionCode")]
        [StringLength(4)]
        public string CPositionCode { get; set; }
        [Column("dDateOfApplication", TypeName = "datetime")]
        public DateTime? DDateOfApplication { get; set; }
        [Column("cEmployeeReferralNo")]
        [StringLength(6)]
        public string CEmployeeReferralNo { get; set; }
        [Column("cNewsAdNo")]
        [StringLength(4)]
        public string CNewsAdNo { get; set; }
        [Column("cAgencyCode")]
        [StringLength(4)]
        public string CAgencyCode { get; set; }
        [Column("cContractRecruiterCode")]
        [StringLength(4)]
        public string CContractRecruiterCode { get; set; }
        [Column("cJobFairCode")]
        [StringLength(4)]
        public string CJobFairCode { get; set; }
        [Column("cCampusRecruitmentCode")]
        [StringLength(4)]
        public string CCampusRecruitmentCode { get; set; }
        [Column("cExEmployeeCode")]
        [StringLength(6)]
        public string CExEmployeeCode { get; set; }
        [Column("vQualification")]
        [StringLength(20)]
        public string VQualification { get; set; }
        [Column("siPrevWorkExperience")]
        public short? SiPrevWorkExperience { get; set; }
        [Column("dBirthDate", TypeName = "datetime")]
        public DateTime? DBirthDate { get; set; }
        [Column("cSex")]
        [StringLength(1)]
        public string CSex { get; set; }
        [Column("cCollegeCode")]
        [StringLength(4)]
        public string CCollegeCode { get; set; }
        [Column("mPrevAnnualSalary", TypeName = "money")]
        public decimal? MPrevAnnualSalary { get; set; }
        [Column("imPhotograph", TypeName = "image")]
        public byte[] ImPhotograph { get; set; }
        [Column("vEmailId")]
        [StringLength(20)]
        public string VEmailId { get; set; }
        [Column("cStatus")]
        [StringLength(1)]
        public string CStatus { get; set; }
        [Column("dTestDate", TypeName = "datetime")]
        public DateTime? DTestDate { get; set; }
        [Column("siTestScore")]
        public short? SiTestScore { get; set; }
        [Column("dInterviewDate", TypeName = "datetime")]
        public DateTime? DInterviewDate { get; set; }
        [Column("cInterviewer")]
        [StringLength(20)]
        public string CInterviewer { get; set; }
        [Column("vInterviewComments")]
        [StringLength(256)]
        public string VInterviewComments { get; set; }
        [Column("cRating")]
        [StringLength(1)]
        public string CRating { get; set; }

        [ForeignKey(nameof(CAgencyCode))]
        [InverseProperty(nameof(RecruitmentAgency.ExternalCandidates))]
        public virtual RecruitmentAgency CAgencyCodeNavigation { get; set; }
        [ForeignKey(nameof(CCampusRecruitmentCode))]
        [InverseProperty(nameof(CampusRecruitment.ExternalCandidates))]
        public virtual CampusRecruitment CCampusRecruitmentCodeNavigation { get; set; }
        [ForeignKey(nameof(CContractRecruiterCode))]
        [InverseProperty(nameof(ContractRecruiter.ExternalCandidates))]
        public virtual ContractRecruiter CContractRecruiterCodeNavigation { get; set; }
        [ForeignKey(nameof(CCountryCode))]
        [InverseProperty(nameof(Country.ExternalCandidates))]
        public virtual Country CCountryCodeNavigation { get; set; }
        [ForeignKey(nameof(CJobFairCode))]
        [InverseProperty(nameof(JobFair.ExternalCandidates))]
        public virtual JobFair CJobFairCodeNavigation { get; set; }
        [ForeignKey(nameof(CNewsAdNo))]
        [InverseProperty(nameof(NewsAd.ExternalCandidates))]
        public virtual NewsAd CNewsAdNoNavigation { get; set; }
        [ForeignKey(nameof(CPositionCode))]
        [InverseProperty(nameof(Position.ExternalCandidates))]
        public virtual Position CPositionCodeNavigation { get; set; }
        [InverseProperty(nameof(CandidateSkill.CCandidateCodeNavigation))]
        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; }
        [InverseProperty(nameof(EmployeeReferral.CCandidateCodeNavigation))]
        public virtual ICollection<EmployeeReferral> EmployeeReferrals { get; set; }
    }
}
