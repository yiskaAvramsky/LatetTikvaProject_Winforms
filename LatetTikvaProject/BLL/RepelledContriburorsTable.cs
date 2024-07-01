using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class RepelledContriburorsTable:GeneralTable
    {
        Repelled r;
        public RepelledContriburorsTable() : base("RepelledContriburors")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Repelled(item));
            }
        }
        public List<Repelled> GetList()
        {
            return base.list.ConvertAll(x => (Repelled)x);
        }
        public int CodeRepelled()
        { 
            return GetList().Max(x => x.codeRepelled) + 1;
        }
    }
}
