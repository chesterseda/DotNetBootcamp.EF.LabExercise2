using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("NewsAd")]
    public partial class NewsAd
    {
        public NewsAd()
        {
            ExternalCandidates = new HashSet<ExternalCandidate>();
        }

        [Key]
        [Column("cNewsAdNo")]
        [StringLength(4)]
        public string CNewsAdNo { get; set; }
        [Column("cNewspaperCode")]
        [StringLength(4)]
        public string CNewspaperCode { get; set; }
        [Column("dAdStartDate", TypeName = "datetime")]
        public DateTime? DAdStartDate { get; set; }
        [Column("dDeadline", TypeName = "datetime")]
        public DateTime? DDeadline { get; set; }

        [ForeignKey(nameof(CNewspaperCode))]
        [InverseProperty(nameof(Newspaper.NewsAds))]
        public virtual Newspaper CNewspaperCodeNavigation { get; set; }
        [InverseProperty(nameof(ExternalCandidate.CNewsAdNoNavigation))]
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
    }
}
