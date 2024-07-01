using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class KindOfContributionsTable:GeneralTable
    {
        public KindOfContributionsTable() : base("KindOfContributions")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new KindOfContribution(item));
            }
        }
        public List<KindOfContribution> GetList()
        {
            return base.list.ConvertAll(x => (KindOfContribution)x);
        }

    }
}
