using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dalopt
    {
        Month06Day20Entities ml = new Month06Day20Entities();
        public List<Kq> GetKqs()
        {
            return ml.Kq.ToList();
        }

    }
}
