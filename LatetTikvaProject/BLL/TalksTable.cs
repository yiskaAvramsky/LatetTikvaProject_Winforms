using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class TalksTable : GeneralTable
    {
        public TalksTable() : base("Talks")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Talk(item));
            }
        }
        public List<Talk> GetList()
        {
            return base.list.ConvertAll(x => (Talk)x);
        }
        public int CodeTalk()
        {
            return GetList().Max(x => x.codeTalk) + 1;
        }
    }
}
