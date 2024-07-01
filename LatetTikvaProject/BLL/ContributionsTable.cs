using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class ContributionsTable:GeneralTable
    {
        public ContributionsTable():base("Contributions")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Contribution(item));
            }
        }
        public List  <Contribution> GetList()
        {
            return base.list.ConvertAll(x => (Contribution)x);
        }
        public int CodeContrbution()
        {
            return GetList().Last().codeContribution + 1;
        }
    }
}
