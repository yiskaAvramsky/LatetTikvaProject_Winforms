using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class PartsTable:GeneralTable
    {
        public PartsTable() : base("Parts")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Part(item));
            }
        }
        public List<Part> GetList()
        {
            return base.list.ConvertAll(x => (Part)x);
        }
        public int CodePart()
        {
            return GetList().Max(x => x.codePart) + 1;
        }
    }
}
