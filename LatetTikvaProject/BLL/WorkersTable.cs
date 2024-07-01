using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class WorkersTable:GeneralTable
    {
        public WorkersTable() : base("Workers")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Worker(item));
            }
        }
        public List<Worker> GetList()
        {
            return base.list.ConvertAll(x => (Worker)x);
        }
    }
}
