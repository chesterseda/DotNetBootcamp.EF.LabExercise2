using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("College")]
    public partial class College
    {
        public College()
        {
            CampusRecruitments = new HashSet<CampusRecruitment>();
        }

        [Key]
        [Column("cCollegeCode")]
        [StringLength(4)]
        public string CCollegeCode { get; set; }
        [Required]
        [Column("cCollegeName")]
        [StringLength(30)]
        public string CCollegeName { get; set; }
        [Column("vCollegeAddress")]
        [StringLength(35)]
        public string VCollegeAddress { get; set; }
        [Column("cCity")]
        [StringLength(20)]
        public string CCity { get; set; }
        [Column("cState")]
        [StringLength(20)]
        public string CState { get; set; }
        [Column("cZip")]
        [StringLength(10)]
        public string CZip { get; set; }
        [Column("cPhone")]
        [StringLength(15)]
        public string CPhone { get; set; }

        [InverseProperty(nameof(CampusRecruitment.CCollegeCodeNavigation))]
        public virtual ICollection<CampusRecruitment> CampusRecruitments { get; set; }
    }
}
