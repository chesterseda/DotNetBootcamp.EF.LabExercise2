using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Department")]
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Column("cDepartmentCode")]
        [StringLength(4)]
        public string CDepartmentCode { get; set; }
        [Column("vDepartmentName")]
        [StringLength(25)]
        public string VDepartmentName { get; set; }
        [Column("vDepartmentHead")]
        [StringLength(25)]
        public string VDepartmentHead { get; set; }
        [Column("vLocation")]
        [StringLength(20)]
        public string VLocation { get; set; }

        [InverseProperty(nameof(Employee.CDepartmentCodeNavigation))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
