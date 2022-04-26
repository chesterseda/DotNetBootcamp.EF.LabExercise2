using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RecruitementSolution.Models
{
    [Keyless]
    public partial class Recruitmentuser
    {
        [Column("cUserName")]
        [StringLength(10)]
        public string CUserName { get; set; }
        [Column("cPassword")]
        [StringLength(10)]
        public string CPassword { get; set; }
    }
}
