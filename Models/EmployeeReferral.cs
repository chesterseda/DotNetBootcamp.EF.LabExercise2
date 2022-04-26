using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    public partial class EmployeeReferral
    {
        [Key]
        [Column("cEmployeeReferralNo")]
        [StringLength(6)]
        public string CEmployeeReferralNo { get; set; }
        [Column("cEmployeeCode")]
        [StringLength(6)]
        public string CEmployeeCode { get; set; }
        [Column("cCandidateCode")]
        [StringLength(6)]
        public string CCandidateCode { get; set; }

        [ForeignKey(nameof(CCandidateCode))]
        [InverseProperty(nameof(ExternalCandidate.EmployeeReferrals))]
        public virtual ExternalCandidate CCandidateCodeNavigation { get; set; }
        [ForeignKey(nameof(CEmployeeCode))]
        [InverseProperty(nameof(Employee.EmployeeReferrals))]
        public virtual Employee CEmployeeCodeNavigation { get; set; }
    }
}
