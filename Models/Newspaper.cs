using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Newspaper")]
    public partial class Newspaper
    {
        public Newspaper()
        {
            NewsAds = new HashSet<NewsAd>();
        }

        [Key]
        [Column("cNewspaperCode")]
        [StringLength(4)]
        public string CNewspaperCode { get; set; }
        [Required]
        [Column("cNewspaperName")]
        [StringLength(20)]
        public string CNewspaperName { get; set; }
        [Column("vRegion")]
        [StringLength(20)]
        public string VRegion { get; set; }
        [Column("vTypeOfNewspaper")]
        [StringLength(20)]
        public string VTypeOfNewspaper { get; set; }
        [Column("vContactPerson")]
        [StringLength(35)]
        public string VContactPerson { get; set; }
        [Column("vHOAddress")]
        [StringLength(35)]
        public string VHoaddress { get; set; }
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
        [Column("cFax")]
        [StringLength(15)]
        public string CFax { get; set; }
        [Column("cPhone")]
        [StringLength(15)]
        public string CPhone { get; set; }

        [ForeignKey(nameof(CCountryCode))]
        [InverseProperty(nameof(Country.Newspapers))]
        public virtual Country CCountryCodeNavigation { get; set; }
        [InverseProperty(nameof(NewsAd.CNewspaperCodeNavigation))]
        public virtual ICollection<NewsAd> NewsAds { get; set; }
    }
}
