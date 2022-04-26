using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("ContractRecruiter")]
    public partial class ContractRecruiter
    {
        public ContractRecruiter()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        [Key]
        [Column("cContractRecruiterCode")]
        [StringLength(4)]
        public string CContractRecruiterCode { get; set; }
        [Column("cName")]
        [StringLength(35)]
        public string CName { get; set; }
        [Column("vAddress")]
        [StringLength(35)]
        public string VAddress { get; set; }
        [Column("cCity")]
        [StringLength(20)]
        public string CCity { get; set; }
        [Column("cState")]
        [StringLength(15)]
        public string CState { get; set; }
        [Column("cZip")]
        [StringLength(10)]
        public string CZip { get; set; }
        [Column("cFax")]
        [StringLength(15)]
        public string CFax { get; set; }
        [Column("cPhone")]
        [StringLength(15)]
        public string CPhone { get; set; }
        [Column("siPercentageCharge")]
        public short? SiPercentageCharge { get; set; }
        [Column("mTotalPaid", TypeName = "money")]
        public decimal? MTotalPaid { get; set; }

        [InverseProperty(nameof(ExternalCandidate.CContractRecruiterCodeNavigation))]
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
