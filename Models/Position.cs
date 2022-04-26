using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Position")]
    public partial class Position
    {
        public Position()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
            InternalCandidates = new HashSet<InternalCandidate>();
            PositionSkills = new HashSet<PositionSkill>();
            Requisitions = new HashSet<Requisition>();
        }

        [Key]
        [Column("cPositionCode")]
        [StringLength(4)]
        public string CPositionCode { get; set; }
        [Column("vDescription")]
        [StringLength(35)]
        public string VDescription { get; set; }
        [Column("iBudgetedStrength")]
        public int? IBudgetedStrength { get; set; }
        [Column("siYear")]
        public short? SiYear { get; set; }
        [Column("iCurrentStrength")]
        public int? ICurrentStrength { get; set; }

        [InverseProperty(nameof(ExternalCandidate.CPositionCodeNavigation))]
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
        [InverseProperty(nameof(InternalCandidate.CPositionCodeAppliedForNavigation))]
        public virtual ICollection<InternalCandidate> InternalCandidates { get; set; }
        [InverseProperty(nameof(PositionSkill.CPositionCodeNavigation))]
        public virtual ICollection<PositionSkill> PositionSkills { get; set; }
        [InverseProperty(nameof(Requisition.CPositionCodeNavigation))]
        public virtual ICollection<Requisition> Requisitions { get; set; }
    }
}
