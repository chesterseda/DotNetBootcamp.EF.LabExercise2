using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Employee")]
    [Index(nameof(CSocialSecurityNo), Name = "UQ__Employee__6AB6057F8658A013", IsUnique = true)]
    public partial class Employee
    {
        public Employee()
        {
            AnnualSalaries = new HashSet<AnnualSalary>();
            EmployeeReferrals = new HashSet<EmployeeReferral>();
            EmployeeSkills = new HashSet<EmployeeSkill>();
            MonthlySalaries = new HashSet<MonthlySalary>();
        }

        [Key]
        [Column("cEmployeeCode")]
        [StringLength(6)]
        public string CEmployeeCode { get; set; }
        [Column("vFirstName")]
        [StringLength(20)]
        public string VFirstName { get; set; }
        [Column("vLastName")]
        [StringLength(20)]
        public string VLastName { get; set; }
        [Column("cCandidateCode")]
        [StringLength(6)]
        public string CCandidateCode { get; set; }
        [Column("vAddress")]
        [StringLength(35)]
        public string VAddress { get; set; }
        [Column("cCity")]
        [StringLength(20)]
        public string CCity { get; set; }
        [Column("cState")]
        [StringLength(20)]
        public string CState { get; set; }
        [Column("cZip")]
        [StringLength(10)]
        public string CZip { get; set; }
        [Column("cCountryCode")]
        [StringLength(3)]
        public string CCountryCode { get; set; }
        [Column("cPhone")]
        [StringLength(15)]
        public string CPhone { get; set; }
        [Column("vQualification")]
        [StringLength(20)]
        public string VQualification { get; set; }
        [Column("dBirthDate", TypeName = "datetime")]
        public DateTime? DBirthDate { get; set; }
        [Column("cSex")]
        [StringLength(1)]
        public string CSex { get; set; }
        [Column("cCurrentPosition")]
        [StringLength(20)]
        public string CCurrentPosition { get; set; }
        [Column("cDesignation")]
        [StringLength(20)]
        public string CDesignation { get; set; }
        [Column("cEmailId")]
        [StringLength(20)]
        public string CEmailId { get; set; }
        [Column("cDepartmentCode")]
        [StringLength(4)]
        public string CDepartmentCode { get; set; }
        [Column("cRegion")]
        [StringLength(20)]
        public string CRegion { get; set; }
        [Column("imPhoto", TypeName = "image")]
        public byte[] ImPhoto { get; set; }
        [Column("dJoiningDate", TypeName = "datetime")]
        public DateTime? DJoiningDate { get; set; }
        [Column("dResignationDate", TypeName = "datetime")]
        public DateTime? DResignationDate { get; set; }
        [Column("cSocialSecurityNo")]
        [StringLength(15)]
        public string CSocialSecurityNo { get; set; }
        [Column("cSupervisorCode")]
        [StringLength(6)]
        public string CSupervisorCode { get; set; }

        [ForeignKey(nameof(CCountryCode))]
        [InverseProperty(nameof(Country.Employees))]
        public virtual Country CCountryCodeNavigation { get; set; }
        [ForeignKey(nameof(CDepartmentCode))]
        [InverseProperty(nameof(Department.Employees))]
        public virtual Department CDepartmentCodeNavigation { get; set; }
        [InverseProperty(nameof(AnnualSalary.CEmployeeCodeNavigation))]
        public virtual ICollection<AnnualSalary> AnnualSalaries { get; set; }
        [InverseProperty(nameof(EmployeeReferral.CEmployeeCodeNavigation))]
        public virtual ICollection<EmployeeReferral> EmployeeReferrals { get; set; }
        [InverseProperty(nameof(EmployeeSkill.CEmployeeCodeNavigation))]
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        [InverseProperty(nameof(MonthlySalary.CEmployeeCodeNavigation))]
        public virtual ICollection<MonthlySalary> MonthlySalaries { get; set; }
    }
}
