using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Requisition")]
    public partial class Requisition
    {
        [Key]
        [Column("cRequisitionCode")]
        [StringLength(6)]
        public string CRequisitionCode { get; set; }
        [Key]
        [Column("cPositionCode")]
        [StringLength(4)]
        public string CPositionCode { get; set; }
        [Column("dDateofRequisition", TypeName = "datetime")]
        public DateTime? DDateofRequisition { get; set; }
        [Column("dDeadline", TypeName = "datetime")]
        public DateTime? DDeadline { get; set; }
        [Column("cDepartmentCode")]
        [StringLength(4)]
        public string CDepartmentCode { get; set; }
        [Column("vRegion")]
        [StringLength(20)]
        public string VRegion { get; set; }
        [Column("siNoOfVacancy")]
        public short? SiNoOfVacancy { get; set; }

        [ForeignKey(nameof(CPositionCode))]
        [InverseProperty(nameof(Position.Requisitions))]
        public virtual Position CPositionCodeNavigation { get; set; }
    }
}
