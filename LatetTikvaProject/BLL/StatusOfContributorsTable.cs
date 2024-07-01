using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class StatusOfContributorsTable:GeneralTable
    {
        public StatusOfContributorsTable() : base("StatusOfContributors")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Status(item));
            }
        }
        public List<Status> GetList()
        {
            return base.list.ConvertAll(x => (Status)x);
        }
    }
}
