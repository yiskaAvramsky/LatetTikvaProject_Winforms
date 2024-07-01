using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class TarrifOfBonnusTable:GeneralTable
    {

        public TarrifOfBonnusTable() : base("TarrifOfBonnus")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TarrifOfBonnus(item));
            }
        }
        public List<TarrifOfBonnus> GetList()
        {
            return base.list.ConvertAll(x => (TarrifOfBonnus)x);
        }

    }
}
