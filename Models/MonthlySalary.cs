using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("MonthlySalary")]
    public partial class MonthlySalary
    {
        [Key]
        [Column("cEmployeeCode")]
        [StringLength(6)]
        public string CEmployeeCode { get; set; }
        [Column("mMonthlySalary", TypeName = "money")]
        public decimal? MMonthlySalary { get; set; }
        [Key]
        [Column("dPayDate", TypeName = "datetime")]
        public DateTime DPayDate { get; set; }
        [Column("mReferralBonus", TypeName = "money")]
        public decimal? MReferralBonus { get; set; }

        [ForeignKey(nameof(CEmployeeCode))]
        [InverseProperty(nameof(Employee.MonthlySalaries))]
        public virtual Employee CEmployeeCodeNavigation { get; set; }
    }
}
