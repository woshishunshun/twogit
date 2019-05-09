using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class Bllopt
    {
        Dalopt dl = new Dalopt();
        //返回所有
        public List<Kq> GetKqs()
        {
            return dl.GetKqs();
        }
        //查询
        public List<Kq> GetCha(string zc = "", string sj = "", string jssj = "")
        {
            var list = dl.GetKqs().ToList();
            if (zc != "")
            {
                list.Where(m => m.Zc == zc).ToList();
            }
            if (sj != "" && jssj != null)
            {
                list.Where(m => m.Qdsj.Contains(sj) && m.Qtsj.Contains(jssj)).ToList();
            }
            return list;
        }
    }
}
