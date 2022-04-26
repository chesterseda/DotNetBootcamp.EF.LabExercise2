using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitementSolution.Data;
using RecruitementSolution.Models;

namespace RecruitementSolution.Repositories
{
    internal class EmployeeSkillGenericRepository
    {
        public RecruitmentContext Context { get; set; }

        public EmployeeSkillGenericRepository(RecruitmentContext context)
        {
            this.Context = context;
        }

        public IEnumerable<dynamic> GetEmployeeSkillsByEmployeeCode(string code)
        {
            var skills = this.Context.EmployeeSkills
                .Join(Context.Skills, employee => employee.CSkillCode, skill => skill.CSkillCode, (employee, skill) => new
                {
                    CEmployeeCode = employee.CEmployeeCode,
                    CSkillCode = skill.VSkill
                }
                )
                .Where(p => p.CEmployeeCode == code)
                .ToList();

            if (skills != null)
            {
                return skills;
            }
            throw new Exception($"~ Doesn't exist");
        }
    }
}
