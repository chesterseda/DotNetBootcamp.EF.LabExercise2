using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("CampusRecruitment")]
    public partial class CampusRecruitment
    {
        public CampusRecruitment()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        [Key]
        [Column("cCampusRecruitmentCode")]
        [StringLength(4)]
        public string CCampusRecruitmentCode { get; set; }
        [Column("cCollegeCode")]
        [StringLength(4)]
        public string CCollegeCode { get; set; }
        [Column("dRecruitmentStartDate", TypeName = "datetime")]
        public DateTime? DRecruitmentStartDate { get; set; }
        [Column("dRecruitmentEndDate", TypeName = "datetime")]
        public DateTime? DRecruitmentEndDate { get; set; }

        [ForeignKey(nameof(CCollegeCode))]
        [InverseProperty(nameof(College.CampusRecruitments))]
        public virtual College CCollegeCodeNavigation { get; set; }
        [InverseProperty(nameof(ExternalCandidate.CCampusRecruitmentCodeNavigation))]
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
