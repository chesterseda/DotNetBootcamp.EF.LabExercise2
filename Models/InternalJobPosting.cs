using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("InternalJobPosting")]
    public partial class InternalJobPosting
    {
        public InternalJobPosting()
        {
            InternalCandidates = new HashSet<InternalCandidate>();
        }

        [Key]
        [Column("cInternalJobPostingCode")]
        [StringLength(4)]
        public string CInternalJobPostingCode { get; set; }
        [Column("cPositionCode")]
        [StringLength(4)]
        public string CPositionCode { get; set; }
        [Column("siNoOfVacancies")]
        public short SiNoOfVacancies { get; set; }
        [Column("vRegion")]
        [StringLength(20)]
        public string VRegion { get; set; }
        [Column("dNoticeReleaseDate", TypeName = "datetime")]
        public DateTime DNoticeReleaseDate { get; set; }
        [Column("dDeadline", TypeName = "datetime")]
        public DateTime? DDeadline { get; set; }

        [InverseProperty(nameof(InternalCandidate.CInternalJobPostingCodeNavigation))]
        public virtual ICollection<InternalCandidate> InternalCandidates { get; set; }
    }
}
