using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("CandidateSkill")]
    public partial class CandidateSkill
    {
        [Key]
        [Column("cCandidateCode")]
        [StringLength(6)]
        public string CCandidateCode { get; set; }
        [Key]
        [Column("cSkillCode")]
        [StringLength(4)]
        public string CSkillCode { get; set; }

        [ForeignKey(nameof(CCandidateCode))]
        [InverseProperty(nameof(ExternalCandidate.CandidateSkills))]
        public virtual ExternalCandidate CCandidateCodeNavigation { get; set; }
        [ForeignKey(nameof(CSkillCode))]
        [InverseProperty(nameof(Skill.CandidateSkills))]
        public virtual Skill CSkillCodeNavigation { get; set; }
    }
}
