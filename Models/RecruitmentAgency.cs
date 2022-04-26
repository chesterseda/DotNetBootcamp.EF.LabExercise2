using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    public partial class RecruitmentAgency
    {
        public RecruitmentAgency()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        [Key]
        [Column("cAgencyCode")]
        [StringLength(4)]
        public string CAgencyCode { get; set; }
        [Column("cName")]
        [StringLength(20)]
        public string CName { get; set; }
        [Column("vAddress")]
        [StringLength(35)]
        public string VAddress { get; set; }
        [Column("cCity")]
        [StringLength(15)]
        public string CCity { get; set; }
        [Column("cState")]
        [StringLength(15)]
        public string CState { get; set; }
        [Column("cZip")]
        [StringLength(10)]
        public string CZip { get; set; }
        [Column("cPhone")]
        [StringLength(15)]
        public string CPhone { get; set; }
        [Column("cFax")]
        [StringLength(15)]
        public string CFax { get; set; }
        [Column("siPercentageCharge")]
        public short? SiPercentageCharge { get; set; }
        [Column("mTotalPaid", TypeName = "money")]
        public decimal? MTotalPaid { get; set; }

        [InverseProperty(nameof(ExternalCandidate.CAgencyCodeNavigation))]
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
