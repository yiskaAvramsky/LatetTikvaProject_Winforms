using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class ContributorsTable:GeneralTable
    {
        public ContributorsTable() : base("Contributors")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Contributor(item));
            }
        }
        public List<Contributor> GetList()
        {
            return base.list.ConvertAll(x => (Contributor)x);
        }

    }
}
