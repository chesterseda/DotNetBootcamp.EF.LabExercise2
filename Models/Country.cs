using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Table("Country")]
    public partial class Country
    {
        public Country()
        {
            Employees = new HashSet<Employee>();
            ExternalCandidates = new HashSet<ExternalCandidate>();
            Newspapers = new HashSet<Newspaper>();
        }

        [Key]
        [Column("cCountryCode")]
        [StringLength(3)]
        public string CCountryCode { get; set; }
        [Required]
        [Column("cCountry")]
        [StringLength(35)]
        public string CCountry { get; set; }

        [InverseProperty(nameof(Employee.CCountryCodeNavigation))]
        public virtual ICollection<Employee> Employees { get; set; }
        [InverseProperty(nameof(ExternalCandidate.CCountryCodeNavigation))]
        public virtual ICollection<ExternalCandidate> ExternalCandidates { get; set; }
        [InverseProperty(nameof(Newspaper.CCountryCodeNavigation))]
        public virtual ICollection<Newspaper> Newspapers { get; set; }
    }
}
