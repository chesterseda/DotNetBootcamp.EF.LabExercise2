using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("AnnualSalary")]
    public partial class AnnualSalary
    {
        [Key]
        [Column("cEmployeeCode")]
        [StringLength(6)]
        public string CEmployeeCode { get; set; }
        [Column("mAnnualSalary", TypeName = "money")]
        public decimal? MAnnualSalary { get; set; }
        [Key]
        [Column("siYear")]
        public short SiYear { get; set; }

        [ForeignKey(nameof(CEmployeeCode))]
        [InverseProperty(nameof(Employee.AnnualSalaries))]
        public virtual Employee CEmployeeCodeNavigation { get; set; }
    }
}
