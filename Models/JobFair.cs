using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("JobFair")]
    public partial class JobFair
    {
        public JobFair()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        [Key]
        [Column("cJobFairCode")]
        [StringLength(4)]
        public string CJobFairCode { get; set; }
        [Column("vLocation")]
        [StringLength(35)]
        public string VLocation { get; set; }
        [Column("vJobFairCompany")]
        [StringLength(40)]
        public string VJobFairCompany { get; set; }
        [Column("mFee", TypeName = "money")]
        public decimal? MFee { get; set; }
        [Column("dFairDate", TypeName = "datetime")]
        public DateTime? DFairDate { get; set; }

        [InverseProperty(nameof(ExternalCandidate.CJobFairCodeNavigation))]
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
