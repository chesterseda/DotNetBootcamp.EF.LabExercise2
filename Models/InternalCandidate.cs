using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("InternalCandidate")]
    public partial class InternalCandidate
    {
        [Key]
        [Column("cCandidateCode")]
        [StringLength(6)]
        public string CCandidateCode { get; set; }
        [Key]
        [Column("cEmployeeCode")]
        [StringLength(6)]
        public string CEmployeeCode { get; set; }
        [Key]
        [Column("cInternalJobPostingCode")]
        [StringLength(4)]
        public string CInternalJobPostingCode { get; set; }
        [Column("cPositionCodeAppliedFor")]
        [StringLength(4)]
        public string CPositionCodeAppliedFor { get; set; }
        [Column("dDateOfApplication", TypeName = "datetime")]
        public DateTime? DDateOfApplication { get; set; }
        [Column("dTestDate", TypeName = "datetime")]
        public DateTime? DTestDate { get; set; }
        [Column("siTestScore")]
        public short? SiTestScore { get; set; }
        [Column("dInterviewDate", TypeName = "datetime")]
        public DateTime? DInterviewDate { get; set; }
        [Column("cInterviewer")]
        [StringLength(25)]
        public string CInterviewer { get; set; }
        [Column("vInterviewComments")]
        [StringLength(256)]
        public string VInterviewComments { get; set; }
        [Column("cRating")]
        [StringLength(1)]
        public string CRating { get; set; }
        [Column("cStatus")]
        [StringLength(1)]
        public string CStatus { get; set; }

        [ForeignKey(nameof(CInternalJobPostingCode))]
        [InverseProperty(nameof(InternalJobPosting.InternalCandidates))]
        public virtual InternalJobPosting CInternalJobPostingCodeNavigation { get; set; }
        [ForeignKey(nameof(CPositionCodeAppliedFor))]
        [InverseProperty(nameof(Position.InternalCandidates))]
        public virtual Position CPositionCodeAppliedForNavigation { get; set; }
    }
}
