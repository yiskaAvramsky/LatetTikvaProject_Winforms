using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class ListsToTalkTable : GeneralTable
    {
        public ListsToTalkTable() : base("ListToTalk")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ListToTalk(item));
            }
        }
        public List<ListToTalk> GetList()
        {
            return base.list.ConvertAll(x => (ListToTalk)x);
        }
        public int CodeListsToTalk()
        {
            return GetList().Max(x => x.codeListToTalk) + 1;
        }
    }
}
