using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Skill")]
    public partial class Skill
    {
        public Skill()
        {
            CandidateSkills = new HashSet<CandidateSkill>();
            EmployeeSkills = new HashSet<EmployeeSkill>();
            PositionSkills = new HashSet<PositionSkill>();
        }

        [Key]
        [Column("cSkillCode")]
        [StringLength(4)]
        public string CSkillCode { get; set; }
        [Column("vSkill")]
        [StringLength(35)]
        public string VSkill { get; set; }

        [InverseProperty(nameof(CandidateSkill.CSkillCodeNavigation))]
        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; }
        [InverseProperty(nameof(EmployeeSkill.CSkillCodeNavigation))]
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        [InverseProperty(nameof(PositionSkill.CSkillCodeNavigation))]
        public virtual ICollection<PositionSkill> PositionSkills { get; set; }
    }
}
