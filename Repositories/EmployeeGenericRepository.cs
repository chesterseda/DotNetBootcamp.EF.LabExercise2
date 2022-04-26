using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitementSolution.Data;
using RecruitementSolution.Models;

namespace RecruitementSolution.Repositories
{
    internal class EmployeeGenericRepository
    {
        public RecruitmentContext Context { get; set; }

        public EmployeeGenericRepository(RecruitmentContext context)
        {
            this.Context = context;
        }

        public Employee FindByCode(string code)
        {
            var employee = this.Context.Employees.Where(p => p.CEmployeeCode == code).FirstOrDefault();
            if (employee != null)
            {
                return employee;
            }
            throw new Exception($"~ Doesn't exist");
        }
    }
}
