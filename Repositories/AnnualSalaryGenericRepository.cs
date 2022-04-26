using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitementSolution.Data;
using RecruitementSolution.Models;

namespace RecruitementSolution.Repositories
{
    internal class AnnualSalaryGenericRepository
    {
        public RecruitmentContext Context { get; set; }

        public AnnualSalaryGenericRepository(RecruitmentContext context)
        {
            this.Context = context;
        }

        public List<AnnualSalary> GetAnnualSalaryByEmployeeCode(string code)
        {
            var annualSalary = this.Context.AnnualSalaries.Where(p => p.CEmployeeCode == code).ToList();
            if (annualSalary != null)
            {
                return annualSalary;
            }
            throw new Exception($"~ Doesn't exist");
        }
    }
}
