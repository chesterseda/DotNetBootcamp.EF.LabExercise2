using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitementSolution.Data;
using RecruitementSolution.Models;

namespace RecruitementSolution.Repositories
{
    internal class PositionGenericRepository
    {
        public RecruitmentContext Context { get; set; }

        public PositionGenericRepository(RecruitmentContext context)
        {
            this.Context = context;
        }

        public Position GetPositionByCode(string code)
        {
            var position = this.Context.Positions.Where(p => p.CPositionCode == code).FirstOrDefault();
            if (position != null)
            {
                return position;
            }
            throw new Exception($"~ doesn't exist");
        }
    }
}
