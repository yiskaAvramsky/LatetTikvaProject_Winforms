using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class TownsTable:GeneralTable
    {
        public TownsTable() : base("Towns")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Town(item));
            }
        }
        public List<Town> GetList()
        {
            return base.list.ConvertAll(x => (Town)x);
        }
        public int CodeTown()
        {
            return GetList().Max(x=>x.codeTown)+ 1;
        }
    }
}
