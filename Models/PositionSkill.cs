using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("PositionSkill")]
    public partial class PositionSkill
    {
        [Key]
        [Column("cPositionCode")]
        [StringLength(4)]
        public string CPositionCode { get; set; }
        [Key]
        [Column("cSkillCode")]
        [StringLength(4)]
        public string CSkillCode { get; set; }

        [ForeignKey(nameof(CPositionCode))]
        [InverseProperty(nameof(Position.PositionSkills))]
        public virtual Position CPositionCodeNavigation { get; set; }
        [ForeignKey(nameof(CSkillCode))]
        [InverseProperty(nameof(Skill.PositionSkills))]
        public virtual Skill CSkillCodeNavigation { get; set; }
    }
}
