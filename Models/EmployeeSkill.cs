using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("EmployeeSkill")]
    public partial class EmployeeSkill
    {
        [Key]
        [Column("cEmployeeCode")]
        [StringLength(6)]
        public string CEmployeeCode { get; set; }
        [Key]
        [Column("cSkillCode")]
        [StringLength(4)]
        public string CSkillCode { get; set; }

        [ForeignKey(nameof(CEmployeeCode))]
        [InverseProperty(nameof(Employee.EmployeeSkills))]
        public virtual Employee CEmployeeCodeNavigation { get; set; }
        [ForeignKey(nameof(CSkillCode))]
        [InverseProperty(nameof(Skill.EmployeeSkills))]
        public virtual Skill CSkillCodeNavigation { get; set; }
    }
}
