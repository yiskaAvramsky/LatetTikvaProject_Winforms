using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class PerformanceContributionsTable:GeneralTable
    {
        public PerformanceContributionsTable() : base("PerformanceContributions")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new PerformanceContribution(item));
            }
        }
        public List<PerformanceContribution> GetList()
        {
            return base.list.ConvertAll(x => (PerformanceContribution)x);
        }
        public int CodePerformanceContrbution()
        {
           return GetList().Max(x => x.codePerformanceContribution) + 1;
        }
    }
}
