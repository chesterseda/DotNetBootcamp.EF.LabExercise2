using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitementSolution.Data;
using RecruitementSolution.Models;

namespace RecruitementSolution.Repositories
{
    internal class MonthlySalaryGenericRepository
    {
        public RecruitmentContext Context { get; set; }

        public MonthlySalaryGenericRepository(RecruitmentContext context)
        {
            this.Context = context;
        }

        public List<MonthlySalary> GetMonthlySalaryByEmployeeCode(string code)
        {
            var monthlySalary = this.Context.MonthlySalaries.Where(p => p.CEmployeeCode == code).ToList();
            if (monthlySalary != null)
            {
                return monthlySalary;
            }
            throw new Exception($"~ Doesn't exist");
        }
    }
}
