using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        [Column("cSourceCode")]
        [StringLength(6)]
        public string CSourceCode { get; set; }
        [Column("mAmount", TypeName = "money")]
        public decimal? MAmount { get; set; }
        [Key]
        [Column("cChequeNo")]
        [StringLength(12)]
        public string CChequeNo { get; set; }
        [Key]
        [Column("dDate", TypeName = "datetime")]
        public DateTime DDate { get; set; }
    }
}
